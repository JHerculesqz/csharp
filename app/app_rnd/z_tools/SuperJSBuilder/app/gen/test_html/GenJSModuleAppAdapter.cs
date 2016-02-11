using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using walle.utils;

namespace SuperJSBuilder
{
    class GenJSModuleAppAdapter
    {
        #region Const

        private static string _getIgnoreName()
        {
            return "\\bin\\";
        }

        private static string _getFilePathPrj(string strSrcDirPath)
        {
            return Path.Combine(strSrcDirPath, "walle.prj");
        }

        public static string START_TAG = "//#MODULE_INIT start";
        public static string END_TAG = "//#MODULE_INIT end";

        #endregion

        public static string genModule(string strSrcDirPath)
        {
            //1.get walle.prj
            var strFilePathPrj = _getFilePathPrj(strSrcDirPath);
            var arrModuleNames = File.ReadAllLines(strFilePathPrj);

            //2.遍历
            var strContent = "";
            foreach (var strModuleName in arrModuleNames)
            {
                var strModuleNameFormat = ModuleNameAdapter.formatName(strModuleName, "");
                strContent += strModuleNameFormat;
                if (arrModuleNames.Last() != strModuleName)
                {
                    strContent += ",";
                    strContent += Environment.NewLine;
                }
            }

            return strContent;
        }
    }
}
