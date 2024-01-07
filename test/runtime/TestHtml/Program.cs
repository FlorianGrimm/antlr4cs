#nullable enable

using Antlr4.Runtime;

using System.Runtime.CompilerServices;

namespace TestHtml;

internal class Program {
    static void Main(string[] args) {
        var location = getLocation();
        if (location == null) { throw new Exception("cannot be"); }
        var examples = System.IO.Path.Combine(location, @"html\examples");
        var listExampleFile = System.IO.Directory.EnumerateFiles(examples).ToList();
        listExampleFile.Sort();
        var listContent = new List<string>(listExampleFile.Count);
        /*
         0
        1295,677
        1
        3114,7031
        2
        3292,2736
        3
        3298,3833
        4
        4533,1288
        5
        13113,2759
        6
        16093,6917
        7
        16433,1829
        8
        17928,5992
        9
        18060,5037
        18060,7495


        0
        1251,892
        1
        2976,4
        2
        3124,1431
        3
        3126,6866
        4
        4189,0795
        5
        12723,5213
        6
        15510,3831
        7
        15823,7618
        8
        9
        17383,7477
        10
        17660,7933
        11
        17662,4186
        12
        32827,4738
        13
        34250,1167
        14
        35867,1506
        15
        37501,7056
        16
        37502,811
        17
        37503,7272
        18
        19
        38196,3746
        20
        747395,998
        747396,4055

         */
        foreach (var exampleFile in listExampleFile.Take(100)) {
            var content = System.IO.File.ReadAllText(exampleFile);
            listContent.Add(content);
        }
        var start = DateTimeOffset.UtcNow;
        int index = 0;
        foreach (var content in listContent) {
            System.Console.WriteLine(index++);
            ICharStream stream = new AntlrInputStream(content);
            ITokenSource lexer = new HTMLLexer(stream);
            ITokenStream tokens = new CommonTokenStream(lexer);
            var parser = new HTMLParser(tokens);
            parser.BuildParseTree = true;
            var (tree, error) = parser.htmlDocument();
            if (tree == null) { System.Console.WriteLine("Failed to parse"); }
            {
                var stop = DateTimeOffset.UtcNow;
                System.Console.WriteLine((stop - start).TotalMilliseconds);
            }
        }
        { 
            var stop = DateTimeOffset.UtcNow;
            System.Console.WriteLine((stop - start).TotalMilliseconds);
            // 747396,4055
        }
    }
    static string? getLocation([CallerFilePath] string? filePath = default) {
        if (string.IsNullOrEmpty(filePath)) { return null; }
        var projectRoot = System.IO.Path.GetDirectoryName(filePath);
        return projectRoot;
    }
}
