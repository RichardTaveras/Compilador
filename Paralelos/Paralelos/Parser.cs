using System;
using System.Collections.Generic;

namespace CompilerApp
{
    public static class Parser
    {
        public static ASTNode Parse(List<string> tokens, SymbolTable symbolTable)
        {
            var root = new ASTNode("Program", new List<ASTNode>());

            int i = 0;
            while (i < tokens.Count)
            {
                if (i + 2 >= tokens.Count)
                    break; // Asegúrate de que hay suficientes tokens para un asignación básica

                var assignment = new ASTNode("Assignment", new List<ASTNode>());
                var identifier = new ASTNode("Identifier", new List<ASTNode> { new ASTNode(tokens[i], new List<ASTNode>()) });
                assignment.Children.Add(identifier);
                symbolTable.AddSymbol(tokens[i], "Variable");
                i++;

                if (i >= tokens.Count)
                    break;

                assignment.Children.Add(new ASTNode("Operator", new List<ASTNode> { new ASTNode(tokens[i], new List<ASTNode>()) }));
                i++;

                if (i >= tokens.Count)
                    break;

                if (char.IsDigit(tokens[i][0]))
                {
                    var number = new ASTNode("Number", new List<ASTNode> { new ASTNode(tokens[i], new List<ASTNode>()) });
                    assignment.Children.Add(number);
                    symbolTable.AddSymbol(tokens[i], "Number");
                }
                else
                {
                    if (i + 2 >= tokens.Count)
                        break; // Asegúrate de que hay suficientes tokens para una expresión

                    var expression = new ASTNode("Expression", new List<ASTNode>());
                    var id1 = new ASTNode("Identifier", new List<ASTNode> { new ASTNode(tokens[i], new List<ASTNode>()) });
                    expression.Children.Add(id1);
                    symbolTable.AddSymbol(tokens[i], "Variable");
                    i++;

                    if (i >= tokens.Count)
                        break;

                    var op = new ASTNode("Operator", new List<ASTNode> { new ASTNode(tokens[i], new List<ASTNode>()) });
                    expression.Children.Add(op);
                    i++;

                    if (i >= tokens.Count)
                        break;

                    var id2 = new ASTNode("Identifier", new List<ASTNode> { new ASTNode(tokens[i], new List<ASTNode>()) });
                    expression.Children.Add(id2);
                    symbolTable.AddSymbol(tokens[i], "Variable");
                    assignment.Children.Add(expression);
                }
                i++;
                root.Children.Add(assignment);

                if (i < tokens.Count && tokens[i] == ";")
                {
                    i++; // Avanza el índice para saltar el punto y coma
                }
            }

            return root;
        }
    }

    public class ASTNode
    {
        public string Name { get; set; }
        public List<ASTNode> Children { get; set; }

        public ASTNode(string name, List<ASTNode> children)
        {
            Name = name;
            Children = children;
        }

        public override string ToString()
        {
            return Name + " [" + string.Join(", ", Children) + "]";
        }
    }
}
