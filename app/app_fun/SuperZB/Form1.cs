using AutoItX3Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperZB
{
    public partial class Form1 : Form
    {
        #region Construction

        public Form1()
        {
            InitializeComponent();
        }

        #endregion

        #region Event

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            foreach (var oProcess in Process.GetProcesses())
            {
                if (oProcess.ProcessName.Contains("Ccit"))
                {
                    oProcess.Kill();
                }
            }

            this.Close();
        }

        #endregion
    }
}
