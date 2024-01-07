﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.7-dev+d0e89de7d6466e1b20a11af31fa604cedf214d00
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from D:\github.com\FlorianGrimm\antlr4cs\test\runtime\TestHtml\html\HTMLLexer.g4 by ANTLR 4.6.7-dev+d0e89de7d6466e1b20a11af31fa604cedf214d00

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace TestHtml {
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.7-dev+d0e89de7d6466e1b20a11af31fa604cedf214d00")]
[System.CLSCompliant(false)]
public partial class HTMLLexer : Lexer {
	public const int
		HTML_COMMENT=1, HTML_CONDITIONAL_COMMENT=2, XML=3, CDATA=4, DTD=5, SCRIPTLET=6, 
		SEA_WS=7, SCRIPT_OPEN=8, STYLE_OPEN=9, TAG_OPEN=10, HTML_TEXT=11, TAG_CLOSE=12, 
		TAG_SLASH_CLOSE=13, TAG_SLASH=14, TAG_EQUALS=15, TAG_NAME=16, TAG_WHITESPACE=17, 
		SCRIPT_BODY=18, SCRIPT_SHORT_BODY=19, STYLE_BODY=20, STYLE_SHORT_BODY=21, 
		ATTVALUE_VALUE=22, ATTRIBUTE=23;
	public const int TAG = 1;
	public const int SCRIPT = 2;
	public const int STYLE = 3;
	public const int ATTVALUE = 4;
	public static string[] modeNames = {
		"DEFAULT_MODE", "TAG", "SCRIPT", "STYLE", "ATTVALUE"
	};

	public static readonly string[] ruleNames = {
		"HTML_COMMENT", "HTML_CONDITIONAL_COMMENT", "XML", "CDATA", "DTD", "SCRIPTLET", 
		"SEA_WS", "SCRIPT_OPEN", "STYLE_OPEN", "TAG_OPEN", "HTML_TEXT", "TAG_CLOSE", 
		"TAG_SLASH_CLOSE", "TAG_SLASH", "TAG_EQUALS", "TAG_NAME", "TAG_WHITESPACE", 
		"HEXDIGIT", "DIGIT", "TAG_NameChar", "TAG_NameStartChar", "SCRIPT_BODY", 
		"SCRIPT_SHORT_BODY", "STYLE_BODY", "STYLE_SHORT_BODY", "ATTVALUE_VALUE", 
		"ATTRIBUTE", "ATTCHARS", "ATTCHAR", "HEXCHARS", "DECCHARS", "DOUBLE_QUOTE_STRING", 
		"SINGLE_QUOTE_STRING"
	};


	public HTMLLexer(ICharStream input)
		: base(input)
	{
		_interp = new LexerATNSimulator(this,_ATN);
	}

	private static readonly string[] _LiteralNames = {
		null, null, null, null, null, null, null, null, null, null, "'<'", null, 
		"'>'", "'/>'", "'/'", "'='"
	};
	private static readonly string[] _SymbolicNames = {
		null, "HTML_COMMENT", "HTML_CONDITIONAL_COMMENT", "XML", "CDATA", "DTD", 
		"SCRIPTLET", "SEA_WS", "SCRIPT_OPEN", "STYLE_OPEN", "TAG_OPEN", "HTML_TEXT", 
		"TAG_CLOSE", "TAG_SLASH_CLOSE", "TAG_SLASH", "TAG_EQUALS", "TAG_NAME", 
		"TAG_WHITESPACE", "SCRIPT_BODY", "SCRIPT_SHORT_BODY", "STYLE_BODY", "STYLE_SHORT_BODY", 
		"ATTVALUE_VALUE", "ATTRIBUTE"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[System.Obsolete("Use Vocabulary instead.")]
	public static readonly string[] tokenNames = GenerateTokenNames(DefaultVocabulary, _SymbolicNames.Length);

	private static string[] GenerateTokenNames(IVocabulary vocabulary, int length) {
		string[] tokenNames = new string[length];
		for (int i = 0; i < tokenNames.Length; i++) {
			tokenNames[i] = vocabulary.GetLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = vocabulary.GetSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}

		return tokenNames;
	}

	[System.Obsolete("Use IRecognizer.Vocabulary instead.")]
	public override string[] TokenNames
	{
		get
		{
			return tokenNames;
		}
	}

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "HTMLLexer.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x2\x19\x17D\b\x1\b"+
		"\x1\b\x1\b\x1\b\x1\x4\x2\t\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t"+
		"\x6\x4\a\t\a\x4\b\t\b\x4\t\t\t\x4\n\t\n\x4\v\t\v\x4\f\t\f\x4\r\t\r\x4"+
		"\xE\t\xE\x4\xF\t\xF\x4\x10\t\x10\x4\x11\t\x11\x4\x12\t\x12\x4\x13\t\x13"+
		"\x4\x14\t\x14\x4\x15\t\x15\x4\x16\t\x16\x4\x17\t\x17\x4\x18\t\x18\x4\x19"+
		"\t\x19\x4\x1A\t\x1A\x4\x1B\t\x1B\x4\x1C\t\x1C\x4\x1D\t\x1D\x4\x1E\t\x1E"+
		"\x4\x1F\t\x1F\x4 \t \x4!\t!\x4\"\t\"\x3\x2\x3\x2\x3\x2\x3\x2\x3\x2\x3"+
		"\x2\a\x2P\n\x2\f\x2\xE\x2S\v\x2\x3\x2\x3\x2\x3\x2\x3\x2\x3\x3\x3\x3\x3"+
		"\x3\x3\x3\x3\x3\a\x3^\n\x3\f\x3\xE\x3\x61\v\x3\x3\x3\x3\x3\x3\x3\x3\x4"+
		"\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\a\x4m\n\x4\f\x4\xE\x4p\v\x4\x3\x4"+
		"\x3\x4\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3"+
		"\x5\a\x5\x7F\n\x5\f\x5\xE\x5\x82\v\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x6\x3"+
		"\x6\x3\x6\x3\x6\a\x6\x8C\n\x6\f\x6\xE\x6\x8F\v\x6\x3\x6\x3\x6\x3\a\x3"+
		"\a\x3\a\x3\a\a\a\x97\n\a\f\a\xE\a\x9A\v\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3"+
		"\a\a\a\xA2\n\a\f\a\xE\a\xA5\v\a\x3\a\x3\a\x5\a\xA9\n\a\x3\b\x3\b\x5\b"+
		"\xAD\n\b\x3\b\x6\b\xB0\n\b\r\b\xE\b\xB1\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t"+
		"\x3\t\x3\t\x3\t\a\t\xBD\n\t\f\t\xE\t\xC0\v\t\x3\t\x3\t\x3\t\x3\t\x3\n"+
		"\x3\n\x3\n\x3\n\x3\n\x3\n\x3\n\x3\n\a\n\xCE\n\n\f\n\xE\n\xD1\v\n\x3\n"+
		"\x3\n\x3\n\x3\n\x3\v\x3\v\x3\v\x3\v\x3\f\x6\f\xDC\n\f\r\f\xE\f\xDD\x3"+
		"\r\x3\r\x3\r\x3\r\x3\xE\x3\xE\x3\xE\x3\xE\x3\xE\x3\xF\x3\xF\x3\x10\x3"+
		"\x10\x3\x10\x3\x10\x3\x11\x3\x11\a\x11\xF1\n\x11\f\x11\xE\x11\xF4\v\x11"+
		"\x3\x12\x3\x12\x3\x12\x3\x12\x3\x13\x3\x13\x3\x14\x3\x14\x3\x15\x3\x15"+
		"\x3\x15\x3\x15\x5\x15\x102\n\x15\x3\x16\x5\x16\x105\n\x16\x3\x17\a\x17"+
		"\x108\n\x17\f\x17\xE\x17\x10B\v\x17\x3\x17\x3\x17\x3\x17\x3\x17\x3\x17"+
		"\x3\x17\x3\x17\x3\x17\x3\x17\x3\x17\x3\x17\x3\x17\x3\x18\a\x18\x11A\n"+
		"\x18\f\x18\xE\x18\x11D\v\x18\x3\x18\x3\x18\x3\x18\x3\x18\x3\x18\x3\x18"+
		"\x3\x19\a\x19\x126\n\x19\f\x19\xE\x19\x129\v\x19\x3\x19\x3\x19\x3\x19"+
		"\x3\x19\x3\x19\x3\x19\x3\x19\x3\x19\x3\x19\x3\x19\x3\x19\x3\x1A\a\x1A"+
		"\x137\n\x1A\f\x1A\xE\x1A\x13A\v\x1A\x3\x1A\x3\x1A\x3\x1A\x3\x1A\x3\x1A"+
		"\x3\x1A\x3\x1B\a\x1B\x143\n\x1B\f\x1B\xE\x1B\x146\v\x1B\x3\x1B\x3\x1B"+
		"\x3\x1B\x3\x1B\x3\x1C\x3\x1C\x3\x1C\x3\x1C\x3\x1C\x5\x1C\x151\n\x1C\x3"+
		"\x1D\x6\x1D\x154\n\x1D\r\x1D\xE\x1D\x155\x3\x1D\x5\x1D\x159\n\x1D\x3\x1E"+
		"\x5\x1E\x15C\n\x1E\x3\x1F\x3\x1F\x6\x1F\x160\n\x1F\r\x1F\xE\x1F\x161\x3"+
		" \x6 \x165\n \r \xE \x166\x3 \x5 \x16A\n \x3!\x3!\a!\x16E\n!\f!\xE!\x171"+
		"\v!\x3!\x3!\x3\"\x3\"\a\"\x177\n\"\f\"\xE\"\x17A\v\"\x3\"\x3\"\xFQ_n\x80"+
		"\x8D\x98\xA3\xBE\xCF\x109\x11B\x127\x138\x2\x2#\a\x2\x3\t\x2\x4\v\x2\x5"+
		"\r\x2\x6\xF\x2\a\x11\x2\b\x13\x2\t\x15\x2\n\x17\x2\v\x19\x2\f\x1B\x2\r"+
		"\x1D\x2\xE\x1F\x2\xF!\x2\x10#\x2\x11%\x2\x12\'\x2\x13)\x2\x2+\x2\x2-\x2"+
		"\x2/\x2\x2\x31\x2\x14\x33\x2\x15\x35\x2\x16\x37\x2\x17\x39\x2\x18;\x2"+
		"\x19=\x2\x2?\x2\x2\x41\x2\x2\x43\x2\x2\x45\x2\x2G\x2\x2\a\x2\x3\x4\x5"+
		"\x6\r\x4\x2\v\v\"\"\x3\x2>>\x5\x2\v\f\xF\xF\"\"\x5\x2\x32;\x43H\x63h\x3"+
		"\x2\x32;\x4\x2/\x30\x61\x61\x5\x2\xB9\xB9\x302\x371\x2041\x2042\n\x2<"+
		"<\x43\\\x63|\x2072\x2191\x2C02\x2FF1\x3003\xD801\xF902\xFDD1\xFDF2\xFFFF"+
		"\t\x2%%-=??\x41\x41\x43\\\x61\x61\x63|\x4\x2$$>>\x4\x2))>>\x190\x2\a\x3"+
		"\x2\x2\x2\x2\t\x3\x2\x2\x2\x2\v\x3\x2\x2\x2\x2\r\x3\x2\x2\x2\x2\xF\x3"+
		"\x2\x2\x2\x2\x11\x3\x2\x2\x2\x2\x13\x3\x2\x2\x2\x2\x15\x3\x2\x2\x2\x2"+
		"\x17\x3\x2\x2\x2\x2\x19\x3\x2\x2\x2\x2\x1B\x3\x2\x2\x2\x3\x1D\x3\x2\x2"+
		"\x2\x3\x1F\x3\x2\x2\x2\x3!\x3\x2\x2\x2\x3#\x3\x2\x2\x2\x3%\x3\x2\x2\x2"+
		"\x3\'\x3\x2\x2\x2\x4\x31\x3\x2\x2\x2\x4\x33\x3\x2\x2\x2\x5\x35\x3\x2\x2"+
		"\x2\x5\x37\x3\x2\x2\x2\x6\x39\x3\x2\x2\x2\x6;\x3\x2\x2\x2\aI\x3\x2\x2"+
		"\x2\tX\x3\x2\x2\x2\v\x65\x3\x2\x2\x2\rs\x3\x2\x2\x2\xF\x87\x3\x2\x2\x2"+
		"\x11\xA8\x3\x2\x2\x2\x13\xAF\x3\x2\x2\x2\x15\xB3\x3\x2\x2\x2\x17\xC5\x3"+
		"\x2\x2\x2\x19\xD6\x3\x2\x2\x2\x1B\xDB\x3\x2\x2\x2\x1D\xDF\x3\x2\x2\x2"+
		"\x1F\xE3\x3\x2\x2\x2!\xE8\x3\x2\x2\x2#\xEA\x3\x2\x2\x2%\xEE\x3\x2\x2\x2"+
		"\'\xF5\x3\x2\x2\x2)\xF9\x3\x2\x2\x2+\xFB\x3\x2\x2\x2-\x101\x3\x2\x2\x2"+
		"/\x104\x3\x2\x2\x2\x31\x109\x3\x2\x2\x2\x33\x11B\x3\x2\x2\x2\x35\x127"+
		"\x3\x2\x2\x2\x37\x138\x3\x2\x2\x2\x39\x144\x3\x2\x2\x2;\x150\x3\x2\x2"+
		"\x2=\x153\x3\x2\x2\x2?\x15B\x3\x2\x2\x2\x41\x15D\x3\x2\x2\x2\x43\x164"+
		"\x3\x2\x2\x2\x45\x16B\x3\x2\x2\x2G\x174\x3\x2\x2\x2IJ\a>\x2\x2JK\a#\x2"+
		"\x2KL\a/\x2\x2LM\a/\x2\x2MQ\x3\x2\x2\x2NP\v\x2\x2\x2ON\x3\x2\x2\x2PS\x3"+
		"\x2\x2\x2QR\x3\x2\x2\x2QO\x3\x2\x2\x2RT\x3\x2\x2\x2SQ\x3\x2\x2\x2TU\a"+
		"/\x2\x2UV\a/\x2\x2VW\a@\x2\x2W\b\x3\x2\x2\x2XY\a>\x2\x2YZ\a#\x2\x2Z[\a"+
		"]\x2\x2[_\x3\x2\x2\x2\\^\v\x2\x2\x2]\\\x3\x2\x2\x2^\x61\x3\x2\x2\x2_`"+
		"\x3\x2\x2\x2_]\x3\x2\x2\x2`\x62\x3\x2\x2\x2\x61_\x3\x2\x2\x2\x62\x63\a"+
		"_\x2\x2\x63\x64\a@\x2\x2\x64\n\x3\x2\x2\x2\x65\x66\a>\x2\x2\x66g\a\x41"+
		"\x2\x2gh\az\x2\x2hi\ao\x2\x2ij\an\x2\x2jn\x3\x2\x2\x2km\v\x2\x2\x2lk\x3"+
		"\x2\x2\x2mp\x3\x2\x2\x2no\x3\x2\x2\x2nl\x3\x2\x2\x2oq\x3\x2\x2\x2pn\x3"+
		"\x2\x2\x2qr\a@\x2\x2r\f\x3\x2\x2\x2st\a>\x2\x2tu\a#\x2\x2uv\a]\x2\x2v"+
		"w\a\x45\x2\x2wx\a\x46\x2\x2xy\a\x43\x2\x2yz\aV\x2\x2z{\a\x43\x2\x2{|\a"+
		"]\x2\x2|\x80\x3\x2\x2\x2}\x7F\v\x2\x2\x2~}\x3\x2\x2\x2\x7F\x82\x3\x2\x2"+
		"\x2\x80\x81\x3\x2\x2\x2\x80~\x3\x2\x2\x2\x81\x83\x3\x2\x2\x2\x82\x80\x3"+
		"\x2\x2\x2\x83\x84\a_\x2\x2\x84\x85\a_\x2\x2\x85\x86\a@\x2\x2\x86\xE\x3"+
		"\x2\x2\x2\x87\x88\a>\x2\x2\x88\x89\a#\x2\x2\x89\x8D\x3\x2\x2\x2\x8A\x8C"+
		"\v\x2\x2\x2\x8B\x8A\x3\x2\x2\x2\x8C\x8F\x3\x2\x2\x2\x8D\x8E\x3\x2\x2\x2"+
		"\x8D\x8B\x3\x2\x2\x2\x8E\x90\x3\x2\x2\x2\x8F\x8D\x3\x2\x2\x2\x90\x91\a"+
		"@\x2\x2\x91\x10\x3\x2\x2\x2\x92\x93\a>\x2\x2\x93\x94\a\x41\x2\x2\x94\x98"+
		"\x3\x2\x2\x2\x95\x97\v\x2\x2\x2\x96\x95\x3\x2\x2\x2\x97\x9A\x3\x2\x2\x2"+
		"\x98\x99\x3\x2\x2\x2\x98\x96\x3\x2\x2\x2\x99\x9B\x3\x2\x2\x2\x9A\x98\x3"+
		"\x2\x2\x2\x9B\x9C\a\x41\x2\x2\x9C\xA9\a@\x2\x2\x9D\x9E\a>\x2\x2\x9E\x9F"+
		"\a\'\x2\x2\x9F\xA3\x3\x2\x2\x2\xA0\xA2\v\x2\x2\x2\xA1\xA0\x3\x2\x2\x2"+
		"\xA2\xA5\x3\x2\x2\x2\xA3\xA4\x3\x2\x2\x2\xA3\xA1\x3\x2\x2\x2\xA4\xA6\x3"+
		"\x2\x2\x2\xA5\xA3\x3\x2\x2\x2\xA6\xA7\a\'\x2\x2\xA7\xA9\a@\x2\x2\xA8\x92"+
		"\x3\x2\x2\x2\xA8\x9D\x3\x2\x2\x2\xA9\x12\x3\x2\x2\x2\xAA\xB0\t\x2\x2\x2"+
		"\xAB\xAD\a\xF\x2\x2\xAC\xAB\x3\x2\x2\x2\xAC\xAD\x3\x2\x2\x2\xAD\xAE\x3"+
		"\x2\x2\x2\xAE\xB0\a\f\x2\x2\xAF\xAA\x3\x2\x2\x2\xAF\xAC\x3\x2\x2\x2\xB0"+
		"\xB1\x3\x2\x2\x2\xB1\xAF\x3\x2\x2\x2\xB1\xB2\x3\x2\x2\x2\xB2\x14\x3\x2"+
		"\x2\x2\xB3\xB4\a>\x2\x2\xB4\xB5\au\x2\x2\xB5\xB6\a\x65\x2\x2\xB6\xB7\a"+
		"t\x2\x2\xB7\xB8\ak\x2\x2\xB8\xB9\ar\x2\x2\xB9\xBA\av\x2\x2\xBA\xBE\x3"+
		"\x2\x2\x2\xBB\xBD\v\x2\x2\x2\xBC\xBB\x3\x2\x2\x2\xBD\xC0\x3\x2\x2\x2\xBE"+
		"\xBF\x3\x2\x2\x2\xBE\xBC\x3\x2\x2\x2\xBF\xC1\x3\x2\x2\x2\xC0\xBE\x3\x2"+
		"\x2\x2\xC1\xC2\a@\x2\x2\xC2\xC3\x3\x2\x2\x2\xC3\xC4\b\t\x2\x2\xC4\x16"+
		"\x3\x2\x2\x2\xC5\xC6\a>\x2\x2\xC6\xC7\au\x2\x2\xC7\xC8\av\x2\x2\xC8\xC9"+
		"\a{\x2\x2\xC9\xCA\an\x2\x2\xCA\xCB\ag\x2\x2\xCB\xCF\x3\x2\x2\x2\xCC\xCE"+
		"\v\x2\x2\x2\xCD\xCC\x3\x2\x2\x2\xCE\xD1\x3\x2\x2\x2\xCF\xD0\x3\x2\x2\x2"+
		"\xCF\xCD\x3\x2\x2\x2\xD0\xD2\x3\x2\x2\x2\xD1\xCF\x3\x2\x2\x2\xD2\xD3\a"+
		"@\x2\x2\xD3\xD4\x3\x2\x2\x2\xD4\xD5\b\n\x3\x2\xD5\x18\x3\x2\x2\x2\xD6"+
		"\xD7\a>\x2\x2\xD7\xD8\x3\x2\x2\x2\xD8\xD9\b\v\x4\x2\xD9\x1A\x3\x2\x2\x2"+
		"\xDA\xDC\n\x3\x2\x2\xDB\xDA\x3\x2\x2\x2\xDC\xDD\x3\x2\x2\x2\xDD\xDB\x3"+
		"\x2\x2\x2\xDD\xDE\x3\x2\x2\x2\xDE\x1C\x3\x2\x2\x2\xDF\xE0\a@\x2\x2\xE0"+
		"\xE1\x3\x2\x2\x2\xE1\xE2\b\r\x5\x2\xE2\x1E\x3\x2\x2\x2\xE3\xE4\a\x31\x2"+
		"\x2\xE4\xE5\a@\x2\x2\xE5\xE6\x3\x2\x2\x2\xE6\xE7\b\xE\x5\x2\xE7 \x3\x2"+
		"\x2\x2\xE8\xE9\a\x31\x2\x2\xE9\"\x3\x2\x2\x2\xEA\xEB\a?\x2\x2\xEB\xEC"+
		"\x3\x2\x2\x2\xEC\xED\b\x10\x6\x2\xED$\x3\x2\x2\x2\xEE\xF2\x5/\x16\x2\xEF"+
		"\xF1\x5-\x15\x2\xF0\xEF\x3\x2\x2\x2\xF1\xF4\x3\x2\x2\x2\xF2\xF0\x3\x2"+
		"\x2\x2\xF2\xF3\x3\x2\x2\x2\xF3&\x3\x2\x2\x2\xF4\xF2\x3\x2\x2\x2\xF5\xF6"+
		"\t\x4\x2\x2\xF6\xF7\x3\x2\x2\x2\xF7\xF8\b\x12\a\x2\xF8(\x3\x2\x2\x2\xF9"+
		"\xFA\t\x5\x2\x2\xFA*\x3\x2\x2\x2\xFB\xFC\t\x6\x2\x2\xFC,\x3\x2\x2\x2\xFD"+
		"\x102\x5/\x16\x2\xFE\x102\t\a\x2\x2\xFF\x102\x5+\x14\x2\x100\x102\t\b"+
		"\x2\x2\x101\xFD\x3\x2\x2\x2\x101\xFE\x3\x2\x2\x2\x101\xFF\x3\x2\x2\x2"+
		"\x101\x100\x3\x2\x2\x2\x102.\x3\x2\x2\x2\x103\x105\t\t\x2\x2\x104\x103"+
		"\x3\x2\x2\x2\x105\x30\x3\x2\x2\x2\x106\x108\v\x2\x2\x2\x107\x106\x3\x2"+
		"\x2\x2\x108\x10B\x3\x2\x2\x2\x109\x10A\x3\x2\x2\x2\x109\x107\x3\x2\x2"+
		"\x2\x10A\x10C\x3\x2\x2\x2\x10B\x109\x3\x2\x2\x2\x10C\x10D\a>\x2\x2\x10D"+
		"\x10E\a\x31\x2\x2\x10E\x10F\au\x2\x2\x10F\x110\a\x65\x2\x2\x110\x111\a"+
		"t\x2\x2\x111\x112\ak\x2\x2\x112\x113\ar\x2\x2\x113\x114\av\x2\x2\x114"+
		"\x115\a@\x2\x2\x115\x116\x3\x2\x2\x2\x116\x117\b\x17\x5\x2\x117\x32\x3"+
		"\x2\x2\x2\x118\x11A\v\x2\x2\x2\x119\x118\x3\x2\x2\x2\x11A\x11D\x3\x2\x2"+
		"\x2\x11B\x11C\x3\x2\x2\x2\x11B\x119\x3\x2\x2\x2\x11C\x11E\x3\x2\x2\x2"+
		"\x11D\x11B\x3\x2\x2\x2\x11E\x11F\a>\x2\x2\x11F\x120\a\x31\x2\x2\x120\x121"+
		"\a@\x2\x2\x121\x122\x3\x2\x2\x2\x122\x123\b\x18\x5\x2\x123\x34\x3\x2\x2"+
		"\x2\x124\x126\v\x2\x2\x2\x125\x124\x3\x2\x2\x2\x126\x129\x3\x2\x2\x2\x127"+
		"\x128\x3\x2\x2\x2\x127\x125\x3\x2\x2\x2\x128\x12A\x3\x2\x2\x2\x129\x127"+
		"\x3\x2\x2\x2\x12A\x12B\a>\x2\x2\x12B\x12C\a\x31\x2\x2\x12C\x12D\au\x2"+
		"\x2\x12D\x12E\av\x2\x2\x12E\x12F\a{\x2\x2\x12F\x130\an\x2\x2\x130\x131"+
		"\ag\x2\x2\x131\x132\a@\x2\x2\x132\x133\x3\x2\x2\x2\x133\x134\b\x19\x5"+
		"\x2\x134\x36\x3\x2\x2\x2\x135\x137\v\x2\x2\x2\x136\x135\x3\x2\x2\x2\x137"+
		"\x13A\x3\x2\x2\x2\x138\x139\x3\x2\x2\x2\x138\x136\x3\x2\x2\x2\x139\x13B"+
		"\x3\x2\x2\x2\x13A\x138\x3\x2\x2\x2\x13B\x13C\a>\x2\x2\x13C\x13D\a\x31"+
		"\x2\x2\x13D\x13E\a@\x2\x2\x13E\x13F\x3\x2\x2\x2\x13F\x140\b\x1A\x5\x2"+
		"\x140\x38\x3\x2\x2\x2\x141\x143\a\"\x2\x2\x142\x141\x3\x2\x2\x2\x143\x146"+
		"\x3\x2\x2\x2\x144\x142\x3\x2\x2\x2\x144\x145\x3\x2\x2\x2\x145\x147\x3"+
		"\x2\x2\x2\x146\x144\x3\x2\x2\x2\x147\x148\x5;\x1C\x2\x148\x149\x3\x2\x2"+
		"\x2\x149\x14A\b\x1B\x5\x2\x14A:\x3\x2\x2\x2\x14B\x151\x5\x45!\x2\x14C"+
		"\x151\x5G\"\x2\x14D\x151\x5=\x1D\x2\x14E\x151\x5\x41\x1F\x2\x14F\x151"+
		"\x5\x43 \x2\x150\x14B\x3\x2\x2\x2\x150\x14C\x3\x2\x2\x2\x150\x14D\x3\x2"+
		"\x2\x2\x150\x14E\x3\x2\x2\x2\x150\x14F\x3\x2\x2\x2\x151<\x3\x2\x2\x2\x152"+
		"\x154\x5?\x1E\x2\x153\x152\x3\x2\x2\x2\x154\x155\x3\x2\x2\x2\x155\x153"+
		"\x3\x2\x2\x2\x155\x156\x3\x2\x2\x2\x156\x158\x3\x2\x2\x2\x157\x159\a\""+
		"\x2\x2\x158\x157\x3\x2\x2\x2\x158\x159\x3\x2\x2\x2\x159>\x3\x2\x2\x2\x15A"+
		"\x15C\t\n\x2\x2\x15B\x15A\x3\x2\x2\x2\x15C@\x3\x2\x2\x2\x15D\x15F\a%\x2"+
		"\x2\x15E\x160\t\x5\x2\x2\x15F\x15E\x3\x2\x2\x2\x160\x161\x3\x2\x2\x2\x161"+
		"\x15F\x3\x2\x2\x2\x161\x162\x3\x2\x2\x2\x162\x42\x3\x2\x2\x2\x163\x165"+
		"\t\x6\x2\x2\x164\x163\x3\x2\x2\x2\x165\x166\x3\x2\x2\x2\x166\x164\x3\x2"+
		"\x2\x2\x166\x167\x3\x2\x2\x2\x167\x169\x3\x2\x2\x2\x168\x16A\a\'\x2\x2"+
		"\x169\x168\x3\x2\x2\x2\x169\x16A\x3\x2\x2\x2\x16A\x44\x3\x2\x2\x2\x16B"+
		"\x16F\a$\x2\x2\x16C\x16E\n\v\x2\x2\x16D\x16C\x3\x2\x2\x2\x16E\x171\x3"+
		"\x2\x2\x2\x16F\x16D\x3\x2\x2\x2\x16F\x170\x3\x2\x2\x2\x170\x172\x3\x2"+
		"\x2\x2\x171\x16F\x3\x2\x2\x2\x172\x173\a$\x2\x2\x173\x46\x3\x2\x2\x2\x174"+
		"\x178\a)\x2\x2\x175\x177\n\f\x2\x2\x176\x175\x3\x2\x2\x2\x177\x17A\x3"+
		"\x2\x2\x2\x178\x176\x3\x2\x2\x2\x178\x179\x3\x2\x2\x2\x179\x17B\x3\x2"+
		"\x2\x2\x17A\x178\x3\x2\x2\x2\x17B\x17C\a)\x2\x2\x17CH\x3\x2\x2\x2&\x2"+
		"\x3\x4\x5\x6Q_n\x80\x8D\x98\xA3\xA8\xAC\xAF\xB1\xBE\xCF\xDD\xF2\x101\x104"+
		"\x109\x11B\x127\x138\x144\x150\x155\x158\x15B\x161\x166\x169\x16F\x178"+
		"\b\a\x4\x2\a\x5\x2\a\x3\x2\x6\x2\x2\a\x6\x2\x2\x3\x2";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace TestHtml
