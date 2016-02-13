using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperDocBuilder
{
    public partial class MainForm : Form
    {
        #region Construction

        public MainForm()
        {
            InitializeComponent();

            //1.formLoad
            MainFormPlugin.formLoad(this);
        }

        #endregion

        #region run

        private void m_buttonOK_Click(object sender, EventArgs e)
        {
            MainService.getInstance().m_oConfService.save(this.m_textBoxBrowser.Text);
            MainService.getInstance().run();
            MessageBox.Show("生成成功...");
        }

        #endregion

        #region Other.Event

        private void m_buttonBrowser_Click(object sender, EventArgs e)
        {
            var oDialogRes = this.m_folderBrowserDialog.ShowDialog();
            if (oDialogRes == System.Windows.Forms.DialogResult.OK)
            {
                this.m_textBoxBrowser.Text = this.m_folderBrowserDialog.SelectedPath;
                MainService.getInstance().m_oConfService.save(this.m_textBoxBrowser.Text);
            }
        }

        #endregion
    }
}
