namespace walle.update
{
    partial class ConfirmForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmForm));
            this.m_buttonUpdate = new System.Windows.Forms.Button();
            this.m_buttonCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // m_buttonUpdate
            // 
            this.m_buttonUpdate.Location = new System.Drawing.Point(128, 46);
            this.m_buttonUpdate.Name = "m_buttonUpdate";
            this.m_buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.m_buttonUpdate.TabIndex = 0;
            this.m_buttonUpdate.Text = "升级";
            this.m_buttonUpdate.UseVisualStyleBackColor = true;
            this.m_buttonUpdate.Click += new System.EventHandler(this.m_buttonUpdate_Click);
            // 
            // m_buttonCancel
            // 
            this.m_buttonCancel.Location = new System.Drawing.Point(209, 46);
            this.m_buttonCancel.Name = "m_buttonCancel";
            this.m_buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.m_buttonCancel.TabIndex = 1;
            this.m_buttonCancel.Text = "取消";
            this.m_buttonCancel.UseVisualStyleBackColor = true;
            this.m_buttonCancel.Click += new System.EventHandler(this.m_buttonCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "大王，有新版本，升个级吧.......";
            // 
            // ConfirmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 81);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_buttonCancel);
            this.Controls.Add(this.m_buttonUpdate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ConfirmForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "升级";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button m_buttonUpdate;
        private System.Windows.Forms.Button m_buttonCancel;
        private System.Windows.Forms.Label label1;
    }
}