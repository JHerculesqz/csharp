using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using walle.utils;

namespace SuperYF
{
    public partial class MainForm : Form
    {
        #region Construction

        public MainForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Step1

        private void m_buttonStep1_Click(object sender, EventArgs e)
        {
            //1.validate
            if (string.IsNullOrEmpty(this.m_textBoxCompanyName.Text))
            {
                MessageBox.Show("请填写公司名称");
                return;
            }
            if (string.IsNullOrEmpty(this.m_textBoxDirPathStep1.Text))
            {
                MessageBox.Show("请填写公司目录");
                return;
            }

            //2.createDirPath
            MainService.getInstance().m_oStep1Service.createDirPath(this.m_textBoxCompanyName.Text, this.m_textBoxDirPathStep1.Text);
            MessageBox.Show("操作成功...");
        }

        #endregion

        #region Step2

        private void m_buttonRawDataRun_Click(object sender, EventArgs e)
        {
            //1.validate
            if (string.IsNullOrEmpty(this.m_textBoxCompanyName.Text))
            {
                MessageBox.Show("请填写公司名称");
                return;
            }
            if (string.IsNullOrEmpty(this.m_textBoxDirPathStep1.Text))
            {
                MessageBox.Show("请填写公司目录");
                return;
            }
            if (string.IsNullOrEmpty(this.m_textBoxRawDataName.Text))
            {
                MessageBox.Show("请填写凭证名称");
                return;
            }
            if (null == this.m_treeViewRawDataTree || 0 == this.m_treeViewRawDataTree.SelectedNode.Level)
            {
                MessageBox.Show("请选择\"所属经营活动\"的二级节点");
                return;
            }

            //2.createFilePathRawData
            MainService.getInstance().m_oStep2Service.createFilePathRawData(
                this.m_textBoxCompanyName.Text, 
                this.m_textBoxDirPathStep1.Text, 
                this.m_treeViewRawDataTree.SelectedNode.FullPath,
                this.m_textBoxRawDataName.Text,
                this.m_comboBoxRawDataType.SelectedItem.ToString());
            MessageBox.Show("操作成功...");
        }

        private void m_buttonEditFilePathRawData_Click(object sender, EventArgs e)
        {
            var strDirPath = MainService.getInstance().m_oStep1Service.getDirPathRawData(this.m_textBoxCompanyName.Text, this.m_textBoxDirPathStep1.Text);
            ProcessUtils.openApp(strDirPath);
        }

        #endregion

        #region OtherEvent

        private void MainForm_Load(object sender, EventArgs e)
        {
            TreeViewUtils.expandAll(this.m_treeViewRawDataTree);
        }

        private void m_buttonDirPathStep1_Click(object sender, EventArgs e)
        {
            var oDialogRes = this.m_folderBrowserDialog.ShowDialog();
            if (oDialogRes == System.Windows.Forms.DialogResult.OK)
            {
                this.m_textBoxDirPathStep1.Text = this.m_folderBrowserDialog.SelectedPath;
            }
        }


        #endregion
    }
}
