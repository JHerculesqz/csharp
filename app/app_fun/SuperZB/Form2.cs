using AutoItX3Lib;
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

namespace SuperZB
{
    public partial class Form2 : Form
    {
        #region Fields

        private AutoItX3 m_oAutoIt = new AutoItX3();

        #endregion

        #region Construction

        public Form2()
        {
            InitializeComponent();

            var k_hook = new KeyboardHook();
            k_hook.KeyDownEvent += new KeyEventHandler(hook_KeyDown);//钩住键按下
            k_hook.Start();//安装键盘钩子
        }
        
        #endregion

        #region Event

        private void hook_KeyDown(object sender, KeyEventArgs e)
        {
            //判断按下的键（Ctrl + A）
            if (e.KeyValue == (int)Keys.A && (int)Control.ModifierKeys == (int)Keys.Alt)
            {
                this.m_oAutoIt.WinSetState("您的成绩", "", this.m_oAutoIt.SW_HIDE);
                var oForm1 = new Form1();
                oForm1.TopMost = true;
                oForm1.ShowDialog();
            }
        }

        #endregion
    }
}
