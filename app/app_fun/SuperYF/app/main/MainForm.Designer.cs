namespace SuperYF
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
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("1.销售费用");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("2.销售合同");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("1.销售", new System.Windows.Forms.TreeNode[] {
            treeNode19,
            treeNode20});
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("2.研发");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("1.采购合同");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("2.库存管理");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("3.采购", new System.Windows.Forms.TreeNode[] {
            treeNode23,
            treeNode24});
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("1.薪酬");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("2.办公场地");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("3.杂费");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("4.行政", new System.Windows.Forms.TreeNode[] {
            treeNode26,
            treeNode27,
            treeNode28});
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("1.股东投资");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("2.借款");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("3.利息");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("4.押金");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("5.银行转存体现");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("6.其它收支");
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("5.财务", new System.Windows.Forms.TreeNode[] {
            treeNode30,
            treeNode31,
            treeNode32,
            treeNode33,
            treeNode34,
            treeNode35});
            this.m_folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.m_buttonStep1 = new System.Windows.Forms.Button();
            this.m_buttonDirPathStep1 = new System.Windows.Forms.Button();
            this.m_textBoxCompanyName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.m_textBoxDirPathStep1 = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.m_textBoxRawDataName = new System.Windows.Forms.TextBox();
            this.m_buttonRawDataRun = new System.Windows.Forms.Button();
            this.m_treeViewRawDataTree = new System.Windows.Forms.TreeView();
            this.label4 = new System.Windows.Forms.Label();
            this.m_comboBoxRawDataType = new System.Windows.Forms.ComboBox();
            this.m_buttonEditFilePathRawData = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(702, 463);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(694, 437);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "首页";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.m_buttonStep1);
            this.tabPage2.Controls.Add(this.m_buttonDirPathStep1);
            this.tabPage2.Controls.Add(this.m_textBoxCompanyName);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.m_textBoxDirPathStep1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(694, 437);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "1.创建公司";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // m_buttonStep1
            // 
            this.m_buttonStep1.Location = new System.Drawing.Point(432, 69);
            this.m_buttonStep1.Name = "m_buttonStep1";
            this.m_buttonStep1.Size = new System.Drawing.Size(71, 23);
            this.m_buttonStep1.TabIndex = 9;
            this.m_buttonStep1.Text = "创建";
            this.m_buttonStep1.UseVisualStyleBackColor = true;
            this.m_buttonStep1.Click += new System.EventHandler(this.m_buttonStep1_Click);
            // 
            // m_buttonDirPathStep1
            // 
            this.m_buttonDirPathStep1.Location = new System.Drawing.Point(465, 40);
            this.m_buttonDirPathStep1.Name = "m_buttonDirPathStep1";
            this.m_buttonDirPathStep1.Size = new System.Drawing.Size(38, 23);
            this.m_buttonDirPathStep1.TabIndex = 8;
            this.m_buttonDirPathStep1.Text = "...";
            this.m_buttonDirPathStep1.UseVisualStyleBackColor = true;
            // 
            // m_textBoxCompanyName
            // 
            this.m_textBoxCompanyName.Location = new System.Drawing.Point(76, 15);
            this.m_textBoxCompanyName.Name = "m_textBoxCompanyName";
            this.m_textBoxCompanyName.Size = new System.Drawing.Size(427, 21);
            this.m_textBoxCompanyName.TabIndex = 6;
            this.m_textBoxCompanyName.Text = "睿石网云";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "公司目录：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "公司名称：";
            // 
            // m_textBoxDirPathStep1
            // 
            this.m_textBoxDirPathStep1.Location = new System.Drawing.Point(76, 42);
            this.m_textBoxDirPathStep1.Name = "m_textBoxDirPathStep1";
            this.m_textBoxDirPathStep1.Size = new System.Drawing.Size(383, 21);
            this.m_textBoxDirPathStep1.TabIndex = 7;
            this.m_textBoxDirPathStep1.Text = "Z:\\";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.m_textBoxRawDataName);
            this.tabPage3.Controls.Add(this.m_buttonRawDataRun);
            this.tabPage3.Controls.Add(this.m_treeViewRawDataTree);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.m_comboBoxRawDataType);
            this.tabPage3.Controls.Add(this.m_buttonEditFilePathRawData);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(694, 437);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "2.管理凭证";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // m_textBoxRawDataName
            // 
            this.m_textBoxRawDataName.Location = new System.Drawing.Point(105, 45);
            this.m_textBoxRawDataName.Name = "m_textBoxRawDataName";
            this.m_textBoxRawDataName.Size = new System.Drawing.Size(475, 21);
            this.m_textBoxRawDataName.TabIndex = 16;
            // 
            // m_buttonRawDataRun
            // 
            this.m_buttonRawDataRun.Location = new System.Drawing.Point(432, 349);
            this.m_buttonRawDataRun.Name = "m_buttonRawDataRun";
            this.m_buttonRawDataRun.Size = new System.Drawing.Size(71, 23);
            this.m_buttonRawDataRun.TabIndex = 14;
            this.m_buttonRawDataRun.Text = "创建凭证";
            this.m_buttonRawDataRun.UseVisualStyleBackColor = true;
            this.m_buttonRawDataRun.Click += new System.EventHandler(this.m_buttonRawDataRun_Click);
            // 
            // m_treeViewRawDataTree
            // 
            this.m_treeViewRawDataTree.Location = new System.Drawing.Point(105, 72);
            this.m_treeViewRawDataTree.Name = "m_treeViewRawDataTree";
            treeNode19.Name = "Node5";
            treeNode19.Text = "1.销售费用";
            treeNode20.Name = "Node6";
            treeNode20.Text = "2.销售合同";
            treeNode21.Name = "Node0";
            treeNode21.Text = "1.销售";
            treeNode22.Name = "Node1";
            treeNode22.Text = "2.研发";
            treeNode23.Name = "Node7";
            treeNode23.Text = "1.采购合同";
            treeNode24.Name = "Node8";
            treeNode24.Text = "2.库存管理";
            treeNode25.Name = "Node2";
            treeNode25.Text = "3.采购";
            treeNode26.Name = "Node9";
            treeNode26.Text = "1.薪酬";
            treeNode27.Name = "Node10";
            treeNode27.Text = "2.办公场地";
            treeNode28.Name = "Node11";
            treeNode28.Text = "3.杂费";
            treeNode29.Name = "Node3";
            treeNode29.Text = "4.行政";
            treeNode30.Name = "Node12";
            treeNode30.Text = "1.股东投资";
            treeNode31.Name = "Node13";
            treeNode31.Text = "2.借款";
            treeNode32.Name = "Node14";
            treeNode32.Text = "3.利息";
            treeNode33.Name = "Node15";
            treeNode33.Text = "4.押金";
            treeNode34.Name = "Node16";
            treeNode34.Text = "5.银行转存体现";
            treeNode35.Name = "Node17";
            treeNode35.Text = "6.其它收支";
            treeNode36.Name = "Node4";
            treeNode36.Text = "5.财务";
            this.m_treeViewRawDataTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode21,
            treeNode22,
            treeNode25,
            treeNode29,
            treeNode36});
            this.m_treeViewRawDataTree.Size = new System.Drawing.Size(475, 265);
            this.m_treeViewRawDataTree.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 12);
            this.label4.TabIndex = 12;
            // 
            // m_comboBoxRawDataType
            // 
            this.m_comboBoxRawDataType.FormattingEnabled = true;
            this.m_comboBoxRawDataType.Items.AddRange(new object[] {
            "收入",
            "支出"});
            this.m_comboBoxRawDataType.Location = new System.Drawing.Point(105, 20);
            this.m_comboBoxRawDataType.Name = "m_comboBoxRawDataType";
            this.m_comboBoxRawDataType.Size = new System.Drawing.Size(475, 20);
            this.m_comboBoxRawDataType.TabIndex = 11;
            this.m_comboBoxRawDataType.Text = "收入";
            // 
            // m_buttonEditFilePathRawData
            // 
            this.m_buttonEditFilePathRawData.Location = new System.Drawing.Point(509, 349);
            this.m_buttonEditFilePathRawData.Name = "m_buttonEditFilePathRawData";
            this.m_buttonEditFilePathRawData.Size = new System.Drawing.Size(71, 23);
            this.m_buttonEditFilePathRawData.TabIndex = 9;
            this.m_buttonEditFilePathRawData.Text = "管理凭证";
            this.m_buttonEditFilePathRawData.UseVisualStyleBackColor = true;
            this.m_buttonEditFilePathRawData.Click += new System.EventHandler(this.m_buttonEditFilePathRawData_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "所属经营活动：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "凭证名称：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "凭证类型：";
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(694, 437);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "3.生成科目";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 463);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "老婆专用财务软件";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog m_folderBrowserDialog;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button m_buttonStep1;
        private System.Windows.Forms.Button m_buttonDirPathStep1;
        private System.Windows.Forms.TextBox m_textBoxCompanyName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox m_textBoxDirPathStep1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TreeView m_treeViewRawDataTree;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox m_comboBoxRawDataType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button m_buttonEditFilePathRawData;
        private System.Windows.Forms.Button m_buttonRawDataRun;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox m_textBoxRawDataName;
        private System.Windows.Forms.TabPage tabPage4;
    }
}

