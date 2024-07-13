using System;
using System.Collections.Generic;
using System.Text;

namespace CompilerApp
{
    public static class IntermediateCodeGenerator
    {
        public static string Generate(ASTNode ast)
        {
            var code = new StringBuilder();
            GenerateCode(ast, code);
            return code.ToString();
        }

        private static void GenerateCode(ASTNode node, StringBuilder code)
        {
            if (node.Name == "Assignment")
            {
                var identifier = node.Children[0].Children[0].Name;
                var value = node.Children[2].Children[0].Name;
                code.AppendLine($"{identifier} = {value}");
            }
            else if (node.Name == "Expression")
            {
                var left = node.Children[0].Children[0].Name;
                var op = node.Children[1].Children[0].Name;
                var right = node.Children[2].Children[0].Name;
                code.AppendLine($"{left} {op} {right}");
            }
            foreach (var child in node.Children)
            {
                GenerateCode(child, code);
            }
        }
    }
}
