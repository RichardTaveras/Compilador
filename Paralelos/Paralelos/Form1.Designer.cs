namespace CompilerApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.buttonCompile = new System.Windows.Forms.Button();
            this.richTextBoxTokens = new System.Windows.Forms.RichTextBox();
            this.richTextBoxGeneratedCode = new System.Windows.Forms.RichTextBox();
            this.richTextBoxSymbolTable = new System.Windows.Forms.RichTextBox();
            this.richTextBoxCppCode = new System.Windows.Forms.RichTextBox();
            this.labelTokens = new System.Windows.Forms.Label();
            this.labelGeneratedCode = new System.Windows.Forms.Label();
            this.labelSymbolTable = new System.Windows.Forms.Label();
            this.labelCppCode = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(46, 46, 46);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(30, 144, 255);
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(46, 46, 46);
            this.openToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(30, 144, 255);
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(46, 46, 46);
            this.saveToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(30, 144, 255);
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(46, 46, 46);
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(30, 144, 255);
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // textBoxCode
            // 
            this.textBoxCode.BackColor = System.Drawing.Color.FromArgb(46, 46, 46);
            this.textBoxCode.ForeColor = System.Drawing.Color.White;
            this.textBoxCode.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxCode.Location = new System.Drawing.Point(12, 27);
            this.textBoxCode.Multiline = true;
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(776, 100);
            this.textBoxCode.TabIndex = 1;
            // 
            // buttonCompile
            // 
            this.buttonCompile.BackColor = System.Drawing.Color.FromArgb(30, 144, 255);
            this.buttonCompile.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonCompile.ForeColor = System.Drawing.Color.Black;
            this.buttonCompile.Location = new System.Drawing.Point(12, 133);
            this.buttonCompile.Name = "buttonCompile";
            this.buttonCompile.Size = new System.Drawing.Size(100, 30);
            this.buttonCompile.TabIndex = 2;
            this.buttonCompile.Text = "Compilar";
            this.buttonCompile.UseVisualStyleBackColor = false;
            this.buttonCompile.Click += new System.EventHandler(this.buttonCompile_Click);
            // 
            // richTextBoxTokens
            // 
            this.richTextBoxTokens.BackColor = System.Drawing.Color.FromArgb(46, 46, 46);
            this.richTextBoxTokens.ForeColor = System.Drawing.Color.White;
            this.richTextBoxTokens.Location = new System.Drawing.Point(12, 200);
            this.richTextBoxTokens.Name = "richTextBoxTokens";
            this.richTextBoxTokens.ReadOnly = true;
            this.richTextBoxTokens.Size = new System.Drawing.Size(350, 96);
            this.richTextBoxTokens.TabIndex = 3;
            this.richTextBoxTokens.Text = "";
            // 
            // richTextBoxGeneratedCode
            // 
            this.richTextBoxGeneratedCode.BackColor = System.Drawing.Color.FromArgb(46, 46, 46);
            this.richTextBoxGeneratedCode.ForeColor = System.Drawing.Color.White;
            this.richTextBoxGeneratedCode.Location = new System.Drawing.Point(12, 322);
            this.richTextBoxGeneratedCode.Name = "richTextBoxGeneratedCode";
            this.richTextBoxGeneratedCode.ReadOnly = true;
            this.richTextBoxGeneratedCode.Size = new System.Drawing.Size(350, 96);
            this.richTextBoxGeneratedCode.TabIndex = 4;
            this.richTextBoxGeneratedCode.Text = "";
            // 
            // richTextBoxSymbolTable
            // 
            this.richTextBoxSymbolTable.BackColor = System.Drawing.Color.FromArgb(46, 46, 46);
            this.richTextBoxSymbolTable.ForeColor = System.Drawing.Color.White;
            this.richTextBoxSymbolTable.Location = new System.Drawing.Point(438, 200);
            this.richTextBoxSymbolTable.Name = "richTextBoxSymbolTable";
            this.richTextBoxSymbolTable.ReadOnly = true;
            this.richTextBoxSymbolTable.Size = new System.Drawing.Size(350, 96);
            this.richTextBoxSymbolTable.TabIndex = 5;
            this.richTextBoxSymbolTable.Text = "";
            // 
            // richTextBoxCppCode
            // 
            this.richTextBoxCppCode.BackColor = System.Drawing.Color.FromArgb(46, 46, 46);
            this.richTextBoxCppCode.ForeColor = System.Drawing.Color.White;
            this.richTextBoxCppCode.Location = new System.Drawing.Point(438, 322);
            this.richTextBoxCppCode.Name = "richTextBoxCppCode";
            this.richTextBoxCppCode.ReadOnly = true;
            this.richTextBoxCppCode.Size = new System.Drawing.Size(350, 96);
            this.richTextBoxCppCode.TabIndex = 6;
            this.richTextBoxCppCode.Text = "";
            // 
            // labelTokens
            // 
            this.labelTokens.AutoSize = true;
            this.labelTokens.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelTokens.ForeColor = System.Drawing.Color.FromArgb(30, 144, 255);
            this.labelTokens.Location = new System.Drawing.Point(12, 178);
            this.labelTokens.Name = "labelTokens";
            this.labelTokens.Size = new System.Drawing.Size(55, 19);
            this.labelTokens.TabIndex = 7;
            this.labelTokens.Text = "Tokens";
            // 
            // labelGeneratedCode
            // 
            this.labelGeneratedCode.AutoSize = true;
            this.labelGeneratedCode.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelGeneratedCode.ForeColor = System.Drawing.Color.FromArgb(30, 144, 255);
            this.labelGeneratedCode.Location = new System.Drawing.Point(12, 300);
            this.labelGeneratedCode.Name = "labelGeneratedCode";
            this.labelGeneratedCode.Size = new System.Drawing.Size(114, 19);
            this.labelGeneratedCode.TabIndex = 8;
            this.labelGeneratedCode.Text = "Generated Code";
            // 
            // labelSymbolTable
            // 
            this.labelSymbolTable.AutoSize = true;
            this.labelSymbolTable.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelSymbolTable.ForeColor = System.Drawing.Color.FromArgb(30, 144, 255);
            this.labelSymbolTable.Location = new System.Drawing.Point(438, 178);
            this.labelSymbolTable.Name = "labelSymbolTable";
            this.labelSymbolTable.Size = new System.Drawing.Size(98, 19);
            this.labelSymbolTable.TabIndex = 9;
            this.labelSymbolTable.Text = "Symbol Table";
            // 
            // labelCppCode
            // 
            this.labelCppCode.AutoSize = true;
            this.labelCppCode.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelCppCode.ForeColor = System.Drawing.Color.FromArgb(30, 144, 255);
            this.labelCppCode.Location = new System.Drawing.Point(438, 300);
            this.labelCppCode.Name = "labelCppCode";
            this.labelCppCode.Size = new System.Drawing.Size(94, 19);
            this.labelCppCode.TabIndex = 10;
            this.labelCppCode.Text = "C++ Code";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelCppCode);
            this.Controls.Add(this.labelSymbolTable);
            this.Controls.Add(this.labelGeneratedCode);
            this.Controls.Add(this.labelTokens);
            this.Controls.Add(this.richTextBoxCppCode);
            this.Controls.Add(this.richTextBoxSymbolTable);
            this.Controls.Add(this.richTextBoxGeneratedCode);
            this.Controls.Add(this.richTextBoxTokens);
            this.Controls.Add(this.buttonCompile);
            this.Controls.Add(this.textBoxCode);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Compiler App";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.Button buttonCompile;
        private System.Windows.Forms.RichTextBox richTextBoxTokens;
        private System.Windows.Forms.RichTextBox richTextBoxGeneratedCode;
        private System.Windows.Forms.RichTextBox richTextBoxSymbolTable;
        private System.Windows.Forms.RichTextBox richTextBoxCppCode;
        private System.Windows.Forms.Label labelTokens;
        private System.Windows.Forms.Label labelGeneratedCode;
        private System.Windows.Forms.Label labelSymbolTable;
        private System.Windows.Forms.Label labelCppCode;
    }
}
