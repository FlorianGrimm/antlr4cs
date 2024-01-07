#nullable enable

using Antlr4.Runtime;

using System.Runtime.CompilerServices;

namespace TestAntlr4;

internal class Program {
    static void Main(string[] args) {
        var location = getLocation();
        if (location == null) { throw new Exception("cannot be"); }
        var examples = System.IO.Path.Combine(location, @"antlr4\examples");
        var listExampleFile = System.IO.Directory.EnumerateFiles(examples).ToList();
        listExampleFile.Sort();
        var listContent = new List<string>(listExampleFile.Count);
        /*

         */
        foreach (var exampleFile in listExampleFile) {
            var content = System.IO.File.ReadAllText(exampleFile);
            listContent.Add(content);
        }
        var start = DateTimeOffset.UtcNow;
        int index = 0;
        foreach (var content in listContent) {
            System.Console.WriteLine(index++);
            ICharStream stream = new AntlrInputStream(content);
            ITokenSource lexer = new ANTLRv4Lexer(stream);
            ITokenStream tokens = new CommonTokenStream(lexer);
            var parser = new ANTLRv4Parser(tokens);
            parser.BuildParseTree = true;
            var (tree, error) = parser.grammarSpec();
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
