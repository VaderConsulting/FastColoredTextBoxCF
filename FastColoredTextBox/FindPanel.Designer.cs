namespace FastColoredTextBoxNS
{
    partial class FindPanel
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
            this.SuspendLayout();
            // 
            // tbFind
            // 
            this.tbFind.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbFind.Location = new System.Drawing.Point(0, 0);
            this.tbFind.Name = "tbFind";
            this.tbFind.Size = new System.Drawing.Size(201, 21);
            this.tbFind.TabIndex = 0;
            this.tbFind.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFind_KeyPress);
            // 
            // btFind
            // 
            this.btFind.Dock = System.Windows.Forms.DockStyle.Right;
            this.btFind.Location = new System.Drawing.Point(201, 0);
            this.btFind.Name = "btFind";
            this.btFind.Size = new System.Drawing.Size(41, 21);
            this.btFind.TabIndex = 1;
            this.btFind.Text = "Find";
            this.btFind.Click += new System.EventHandler(this.btFind_Click);
            // 
            // FindPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.tbFind);
            this.Controls.Add(this.btFind);
            this.Name = "FindPanel";
            this.Size = new System.Drawing.Size(242, 21);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btFind;
        internal System.Windows.Forms.TextBox tbFind;
    }
}
