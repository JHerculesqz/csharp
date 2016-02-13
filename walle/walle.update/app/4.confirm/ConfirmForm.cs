using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace walle.update
{
    public partial class ConfirmForm : Form
    {
        #region Constrcution

        public ConfirmForm()
        {
            InitializeComponent();
        }

        #endregion

        #region OK

        private void m_buttonUpdate_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        #endregion

        #region Cancel

        private void m_buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        #endregion
    }
}
