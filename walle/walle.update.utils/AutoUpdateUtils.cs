using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using walle.utils;

namespace walle.update
{
    public class AutoUpdateUtils
    {
        public static void update(string strUrlUpdateXML)
        {
            var strFilePathUpdate = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"data\walle.update\walle.update.exe");
            var strFilePathSelf = Application.ExecutablePath;
            ProcessUtils.openApp(strFilePathUpdate, string.Format("{0} {1}", strFilePathSelf, strUrlUpdateXML));
        }
    }
}
