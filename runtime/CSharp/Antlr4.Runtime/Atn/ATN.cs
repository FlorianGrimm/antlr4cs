// Copyright (c) Terence Parr, Sam Harwell. All Rights Reserved.
// Licensed under the BSD License. See LICENSE.txt in the project root for license information.

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Dfa;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Sharpen;

namespace Antlr4.Runtime.Atn;

public class ATN
{
    public const int InvalidAltNumber = 0;

    [NotNull]
    public readonly IList<ATNState> states = new List<ATNState>();

    /// <summary>
    /// Each subrule/rule is a decision point and we must track them so we
    /// can go back later and build DFA predictors for them.
    /// </summary>
    /// <remarks>
    /// Each subrule/rule is a decision point and we must track them so we
    /// can go back later and build DFA predictors for them.  This includes
    /// all the rules, subrules, optional blocks, ()+, ()* etc...
    /// </remarks>
    [NotNull]
    public readonly IList<DecisionState> decisionToState = new List<DecisionState>();

    /// <summary>Maps from rule index to starting state number.</summary>
    public RuleStartState[] ruleToStartState;

    /// <summary>Maps from rule index to stop state number.</summary>
    public RuleStopState[] ruleToStopState;

    [NotNull]
    public readonly IDictionary<string, TokensStartState> modeNameToStartState = new Dictionary<string, TokensStartState>();

    /// <summary>The type of the ATN.</summary>
    public readonly ATNType grammarType;

    /// <summary>The maximum value for any symbol recognized by a transition in the ATN.</summary>
    public readonly int maxTokenType;

    /// <summary>For lexer ATNs, this maps the rule index to the resulting token type.</summary>
    /// <remarks>
    /// For lexer ATNs, this maps the rule index to the resulting token type.
    /// For parser ATNs, this maps the rule index to the generated bypass token
    /// type if the
    /// <see cref="ATNDeserializationOptions.GenerateRuleBypassTransitions()"/>
    /// deserialization option was specified; otherwise, this is
    /// <see langword="null"/>
    /// .
    /// </remarks>
    public int[] ruleToTokenType;

    /// <summary>
    /// For lexer ATNs, this is an array of
    /// <see cref="ILexerAction"/>
    /// objects which may
    /// be referenced by action transitions in the ATN.
    /// </summary>
    public ILexerAction[] lexerActions;

    [NotNull]
    public readonly IList<TokensStartState> modeToStartState = new List<TokensStartState>();

    private readonly ConcurrentDictionary<PredictionContext, PredictionContext> contextCache = new ConcurrentDictionary<PredictionContext, PredictionContext>();

    [NotNull]
    public DFA[] decisionToDFA = new DFA[0];

    [NotNull]
    public DFA[] modeToDFA = new DFA[0];

    protected internal readonly ConcurrentDictionary<int, int> LL1Table = new ConcurrentDictionary<int, int>();

    /// <summary>Used for runtime deserialization of ATNs from strings</summary>
    public ATN([NotNull] ATNType grammarType, int maxTokenType)
    {
        this.grammarType = grammarType;
        this.maxTokenType = maxTokenType;
    }

    /// <summary>
    /// Clears the DFA cached for this ATN.
    /// </summary>
    /// <remarks>
    /// <para>This method is not safe for concurrent use. Since recognizers by default share an <see cref="ATN"/>
    /// instance, all parsing operations by all recognizers using this instance must be stopped before the DFA can
    /// be safely cleared.</para>
    /// </remarks>
    public void ClearDFA()
    {
        decisionToDFA = new DFA[decisionToState.Count];
        for (int i = 0; i < decisionToDFA.Length; i++)
        {
            decisionToDFA[i] = new DFA(decisionToState[i], i);
        }
        modeToDFA = new DFA[modeToStartState.Count];
        for (int i_1 = 0; i_1 < modeToDFA.Length; i_1++)
        {
            modeToDFA[i_1] = new DFA(modeToStartState[i_1]);
        }
        contextCache.Clear();
        LL1Table.Clear();
    }

    public virtual int ContextCacheSize
    {
        get
        {
            return contextCache.Count;
        }
    }

    public virtual PredictionContext GetCachedContext(PredictionContext context)
    {
        return PredictionContext.GetCachedContext(context, contextCache, new PredictionContext.IdentityHashMap());
    }

    public DFA[] DecisionToDfa
    {
        get
        {
            System.Diagnostics.Debug.Assert(decisionToDFA != null && decisionToDFA.Length == decisionToState.Count);
            return decisionToDFA;
        }
    }

    /// <summary>
    /// Compute the set of valid tokens that can occur starting in state
    /// <paramref name="s"/>
    /// .
    /// If
    /// <paramref name="ctx"/>
    /// is
    /// <see cref="PredictionContext.EmptyLocal"/>
    /// , the set of tokens will not include what can follow
    /// the rule surrounding
    /// <paramref name="s"/>
    /// . In other words, the set will be
    /// restricted to tokens reachable staying within
    /// <paramref name="s"/>
    /// 's rule.
    /// </summary>
    [return: NotNull]
    public virtual IntervalSet NextTokens(ATNState s, [NotNull] PredictionContext ctx)
    {
        Args.NotNull("ctx", ctx);
        LL1Analyzer anal = new LL1Analyzer(this);
        IntervalSet next = anal.Look(s, ctx);
        return next;
    }

    /// <summary>
    /// Compute the set of valid tokens that can occur starting in
    /// <paramref name="s"/>
    /// and
    /// staying in same rule.
    /// <see cref="TokenConstants.Epsilon"/>
    /// is in set if we reach end of
    /// rule.
    /// </summary>
    [return: NotNull]
    public virtual IntervalSet NextTokens([NotNull] ATNState s)
    {
        if (s.nextTokenWithinRule != null)
        {
            return s.nextTokenWithinRule;
        }
        s.nextTokenWithinRule = NextTokens(s, PredictionContext.EmptyLocal);
        s.nextTokenWithinRule.SetReadonly(true);
        return s.nextTokenWithinRule;
    }

    public virtual void AddState(ATNState? state)
    {
        if (state != null)
        {
            state.atn = this;
            state.stateNumber = states.Count;
        }
        states.Add(state);
    }

    public virtual void RemoveState([NotNull] ATNState state)
    {
        states[state.stateNumber] = null;
    }

    // just free mem, don't shift states in list
    public virtual void DefineMode([NotNull] string name, [NotNull] TokensStartState s)
    {
        modeNameToStartState[name] = s;
        modeToStartState.Add(s);
        modeToDFA = Arrays.CopyOf(modeToDFA, modeToStartState.Count);
        modeToDFA[modeToDFA.Length - 1] = new DFA(s);
        DefineDecisionState(s);
    }

    public virtual int DefineDecisionState([NotNull] DecisionState s)
    {
        decisionToState.Add(s);
        s.decision = decisionToState.Count - 1;
        decisionToDFA = Arrays.CopyOf(decisionToDFA, decisionToState.Count);
        decisionToDFA[decisionToDFA.Length - 1] = new DFA(s, s.decision);
        return s.decision;
    }

    public virtual DecisionState GetDecisionState(int decision)
    {
        if (decisionToState.Count != 0)
        {
            return decisionToState[decision];
        }
        return null;
    }

    public virtual int NumberOfDecisions
    {
        get
        {
            return decisionToState.Count;
        }
    }

    /// <summary>
    /// Computes the set of input symbols which could follow ATN state number
    /// <paramref name="stateNumber"/>
    /// in the specified full
    /// <paramref name="context"/>
    /// . This method
    /// considers the complete parser context, but does not evaluate semantic
    /// predicates (i.e. all predicates encountered during the calculation are
    /// assumed true). If a path in the ATN exists from the starting state to the
    /// <see cref="RuleStopState"/>
    /// of the outermost context without matching any
    /// symbols,
    /// <see cref="TokenConstants.Eof"/>
    /// is added to the returned set.
    /// <p>If
    /// <paramref name="context"/>
    /// is
    /// <see langword="null"/>
    /// , it is treated as
    /// <see cref="ParserRuleContext.EmptyContext"/>
    /// .</p>
    /// <p>Note that this does NOT give you the set of all tokens that could
    /// appear at a given token position in the input phrase.  In other words, it
    /// does not answer:</p>
    /// <quote>"Given a specific partial input phrase, return the set of all
    /// tokens that can follow the last token in the input phrase."</quote>
    /// <p>The big difference is that with just the input, the parser could land
    /// right in the middle of a lookahead decision. Getting all
    /// <em>possible</em> tokens given a partial input stream is a separate
    /// computation. See https://github.com/antlr/antlr4/issues/1428</p>
    /// <p>For this function, we are specifying an ATN state and call stack to
    /// compute what token(s) can come next and specifically: outside of a
    /// lookahead decision. That is what you want for error reporting and
    /// recovery upon parse error.</p>
    /// </summary>
    /// <param name="stateNumber">the ATN state number</param>
    /// <param name="context">the full parse context</param>
    /// <returns>
    /// The set of potentially valid input symbols which could follow the
    /// specified state in the specified context.
    /// </returns>
    /// <exception cref="System.ArgumentException">
    /// if the ATN does not contain a state with
    /// number
    /// <paramref name="stateNumber"/>
    /// </exception>
    [return: NotNull]
    public virtual IntervalSet GetExpectedTokens(int stateNumber, RuleContext? context)
    {
        if (stateNumber < 0 || stateNumber >= states.Count)
        {
            throw new ArgumentException("Invalid state number.");
        }
        RuleContext ctx = context;
        ATNState s = states[stateNumber];
        IntervalSet following = NextTokens(s);
        if (!following.Contains(TokenConstants.Epsilon))
        {
            return following;
        }
        IntervalSet expected = new IntervalSet();
        expected.AddAll(following);
        expected.Remove(TokenConstants.Epsilon);
        while (ctx != null && ctx.invokingState >= 0 && following.Contains(TokenConstants.Epsilon))
        {
            ATNState invokingState = states[ctx.invokingState];
            RuleTransition rt = (RuleTransition)invokingState.Transition(0);
            following = NextTokens(rt.followState);
            expected.AddAll(following);
            expected.Remove(TokenConstants.Epsilon);
            ctx = ctx.parent;
        }
        if (following.Contains(TokenConstants.Epsilon))
        {
            expected.Add(TokenConstants.Eof);
        }
        return expected;
    }
}
