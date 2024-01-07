// Copyright (c) Terence Parr, Sam Harwell. All Rights Reserved.
// Licensed under the BSD License. See LICENSE.txt in the project root for license information.

using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Sharpen;

namespace Antlr4.Runtime.Dfa;

public class LexerDFASerializer : DFASerializer
{
    public LexerDFASerializer([NotNull] DFA dfa)
        : base(dfa, Vocabulary.EmptyVocabulary)
    {
    }

    [return: NotNull]
    protected internal override string GetEdgeLabel(int i)
    {
        return "'" + (char)i + "'";
    }
}
