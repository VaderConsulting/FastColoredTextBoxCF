namespace FastColoredTextBoxNS
{
    partial class ReplacePanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbFind = new System.Windows.Forms.TextBox();
            this.btFind = new System.Windows.Forms.Button();
            this.tbReplace = new System.Windows.Forms.TextBox();
            this.btReplace = new System.Windows.Forms.Button();
            this.btReplaceAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbFind
            // 
            this.tbFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFind.Location = new System.Drawing.Point(0, 0);
            this.tbFind.Name = "tbFind";
            this.tbFind.Size = new System.Drawing.Size(169, 21);
            this.tbFind.TabIndex = 0;
            this.tbFind.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFind_KeyPress);
            // 
            // btFind
            // 
            this.btFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btFind.Location = new System.Drawing.Point(169, 0);
            this.btFind.Name = "btFind";
            this.btFind.Size = new System.Drawing.Size(43, 21);
            this.btFind.TabIndex = 2;
            this.btFind.Text = "Find";
            this.btFind.Click += new System.EventHandler(this.btFindNext_Click);
            // 
            // tbReplace
            // 
            this.tbReplace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbReplace.Location = new System.Drawing.Point(0, 23);
            this.tbReplace.Name = "tbReplace";
            this.tbReplace.Size = new System.Drawing.Size(169, 21);
            this.tbReplace.TabIndex = 1;
            // 
            // btReplace
            // 
            this.btReplace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btReplace.Location = new System.Drawing.Point(169, 23);
            this.btReplace.Name = "btReplace";
            this.btReplace.Size = new System.Drawing.Size(43, 21);
            this.btReplace.TabIndex = 3;
            this.btReplace.Text = "Rpl";
            this.btReplace.Click += new System.EventHandler(this.btReplace_Click);
            // 
            // btReplaceAll
            // 
            this.btReplaceAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btReplaceAll.Location = new System.Drawing.Point(212, 23);
            this.btReplaceAll.Name = "btReplaceAll";
            this.btReplaceAll.Size = new System.Drawing.Size(49, 21);
            this.btReplaceAll.TabIndex = 4;
            this.btReplaceAll.Text = "Rpl All";
            this.btReplaceAll.Click += new System.EventHandler(this.btReplaceAll_Click);
            // 
            // ReplacePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.btReplaceAll);
            this.Controls.Add(this.btReplace);
            this.Controls.Add(this.tbReplace);
            this.Controls.Add(this.tbFind);
            this.Controls.Add(this.btFind);
            this.Name = "ReplacePanel";
            this.Size = new System.Drawing.Size(261, 44);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btFind;
        internal System.Windows.Forms.TextBox tbFind;
        internal System.Windows.Forms.TextBox tbReplace;
        private System.Windows.Forms.Button btReplace;
        private System.Windows.Forms.Button btReplaceAll;
    }
}
