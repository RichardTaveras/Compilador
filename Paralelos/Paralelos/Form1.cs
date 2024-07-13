using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace CompilerApp
{
    public partial class Form1 : Form
    {
        private SymbolTable symbolTable;

        public Form1()
        {
            InitializeComponent();
            symbolTable = new SymbolTable();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxCode.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, textBoxCode.Text);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCompile_Click(object sender, EventArgs e)
        {
            string code = textBoxCode.Text;

            // Análisis léxico
            var tokens = Lexer.Analyze(code);
            richTextBoxTokens.Text = string.Join("\n", tokens);

            // Análisis sintáctico
            symbolTable = new SymbolTable();
            var ast = Parser.Parse(tokens, symbolTable);

            // Mostrar tabla de símbolos
            richTextBoxSymbolTable.Text = symbolTable.ToString();

            // Generación de código intermedio
            var intermediateCode = IntermediateCodeGenerator.Generate(ast);
            richTextBoxGeneratedCode.Text = intermediateCode;

            // Generación de código en C++
            var cppCode = CodeGenerator.Generate(ast);
            richTextBoxCppCode.Text = cppCode;
        }

        private string ASTToString(ASTNode node)
        {
            if (node == null)
                return "null";
            if (node.Children.Count == 0)
                return node.Name;

            var children = string.Join(", ", node.Children.ConvertAll(child => ASTToString(child)));
            return $"{node.Name} [{children}]";
        }
    }
}
