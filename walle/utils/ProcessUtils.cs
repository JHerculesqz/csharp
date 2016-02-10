using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace walle.utils
{
    public class ProcessUtils
    {
        #region openApp

        public static void openApp(string strFilePath)
        {
            Process.Start(strFilePath);
        }

        #endregion
    }
}
