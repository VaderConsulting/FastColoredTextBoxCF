namespace TesterNS
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            FastColoredTextBoxNS.SyntaxHighlighter syntaxHighlighter1 = new FastColoredTextBoxNS.SyntaxHighlighter();
            this.fastColoredTextBox1 = new FastColoredTextBoxNS.FastColoredTextBox();
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.SuspendLayout();
            // 
            // fastColoredTextBox1
            // 
            this.fastColoredTextBox1.AllowSeveralTextStyleDrawing = false;
            this.fastColoredTextBox1.AutoIndent = true;
            this.fastColoredTextBox1.AutoScroll = true;
            this.fastColoredTextBox1.BackColor = System.Drawing.Color.White;
            this.fastColoredTextBox1.ChangedLineColor = System.Drawing.Color.Transparent;
            this.fastColoredTextBox1.CommentPrefix = "//";
            this.fastColoredTextBox1.CurrentLineColor = System.Drawing.Color.Transparent;
            this.fastColoredTextBox1.DelayedEventsInterval = 200;
            this.fastColoredTextBox1.DelayedTextChangedInterval = 200;
            this.fastColoredTextBox1.DescriptionFile = "";
            this.fastColoredTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fastColoredTextBox1.FindSettings = FastColoredTextBoxNS.FindSettings.MatchCase;
            this.fastColoredTextBox1.FoldingIndicatorColor = System.Drawing.Color.LightGreen;
            this.fastColoredTextBox1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular);
            this.fastColoredTextBox1.HighlightFoldingIndicator = true;
            this.fastColoredTextBox1.IndentBackColor = System.Drawing.Color.White;
            this.fastColoredTextBox1.IsChanged = true;
            this.fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.CSharp;
            this.fastColoredTextBox1.LeftBracket = '(';
            this.fastColoredTextBox1.LeftBracket2 = '\0';
            this.fastColoredTextBox1.LeftPadding = 0;
            this.fastColoredTextBox1.LineInterval = 0;
            this.fastColoredTextBox1.LineNumberColor = System.Drawing.Color.Teal;
            this.fastColoredTextBox1.Location = new System.Drawing.Point(0, 0);
            this.fastColoredTextBox1.Name = "fastColoredTextBox1";
            this.fastColoredTextBox1.NewLine = "\r\n";
            this.fastColoredTextBox1.PreferredLineWidth = 80;
            this.fastColoredTextBox1.ReadOnly = false;
            this.fastColoredTextBox1.RightBracket = ')';
            this.fastColoredTextBox1.RightBracket2 = '\0';
            this.fastColoredTextBox1.SelectedText = "";
            this.fastColoredTextBox1.SelectionLength = 0;
            this.fastColoredTextBox1.SelectionStart = 0;
            this.fastColoredTextBox1.ServiceLinesColor = System.Drawing.Color.Silver;
            this.fastColoredTextBox1.ShowLineNumbers = true;
            this.fastColoredTextBox1.Size = new System.Drawing.Size(240, 268);
            this.fastColoredTextBox1.SyntaxHighlighter = syntaxHighlighter1;
            this.fastColoredTextBox1.TabIndex = 0;
            this.fastColoredTextBox1.TabLength = 4;
            this.fastColoredTextBox1.TText = "";
            this.fastColoredTextBox1.WordWrap = false;
            this.fastColoredTextBox1.WordWrapMode = FastColoredTextBoxNS.WordWrapMode.WordWrapControlWidth;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.fastColoredTextBox1);
            this.KeyPreview = true;
            this.Menu = this.mainMenu1;
            this.Name = "MainForm";
            this.Text = "FastColoredTextBox Demo";
            this.ResumeLayout(false);

        }

        #endregion

        private FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBox1;
        private System.Windows.Forms.MainMenu mainMenu1;


    }
}

