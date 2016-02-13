namespace SuperDocBuilder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.m_textBoxBrowser = new System.Windows.Forms.TextBox();
            this.m_buttonBrowser = new System.Windows.Forms.Button();
            this.m_buttonOK = new System.Windows.Forms.Button();
            this.m_folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "MarkDown目录：";
            // 
            // m_textBoxBrowser
            // 
            this.m_textBoxBrowser.Location = new System.Drawing.Point(108, 13);
            this.m_textBoxBrowser.Name = "m_textBoxBrowser";
            this.m_textBoxBrowser.Size = new System.Drawing.Size(270, 21);
            this.m_textBoxBrowser.TabIndex = 1;
            // 
            // m_buttonBrowser
            // 
            this.m_buttonBrowser.Location = new System.Drawing.Point(384, 11);
            this.m_buttonBrowser.Name = "m_buttonBrowser";
            this.m_buttonBrowser.Size = new System.Drawing.Size(42, 23);
            this.m_buttonBrowser.TabIndex = 2;
            this.m_buttonBrowser.Text = "...";
            this.m_buttonBrowser.UseVisualStyleBackColor = true;
            this.m_buttonBrowser.Click += new System.EventHandler(this.m_buttonBrowser_Click);
            // 
            // m_buttonOK
            // 
            this.m_buttonOK.Location = new System.Drawing.Point(351, 51);
            this.m_buttonOK.Name = "m_buttonOK";
            this.m_buttonOK.Size = new System.Drawing.Size(75, 23);
            this.m_buttonOK.TabIndex = 3;
            this.m_buttonOK.Text = "生成";
            this.m_buttonOK.UseVisualStyleBackColor = true;
            this.m_buttonOK.Click += new System.EventHandler(this.m_buttonOK_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 88);
            this.Controls.Add(this.m_buttonOK);
            this.Controls.Add(this.m_buttonBrowser);
            this.Controls.Add(this.m_textBoxBrowser);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuperDocBuilder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog m_folderBrowserDialog;
        public System.Windows.Forms.TextBox m_textBoxBrowser;
        public System.Windows.Forms.Button m_buttonBrowser;
        public System.Windows.Forms.Button m_buttonOK;
    }
}