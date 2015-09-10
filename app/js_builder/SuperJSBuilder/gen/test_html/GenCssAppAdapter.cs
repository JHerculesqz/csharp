using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using walle.utils;

namespace SuperJSBuilder.gen.test_html
{
    class GenCssAppAdapter
    {
        #region Const

        private static string REPLACE_PATH = "REPLACE_PATH";

        private static string _getFilePathTemplate()
        {
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data/SuperJSBuilder/html_app/css_app.txt");
        }

        private static string PREFIX_FILE = ".less";

        private static string _getIgnoreName()
        {
            return "\\bin\\";
        }

        public static string START_TAG = "<!--css.app start-->";
        public static string END_TAG = "<!--css.app end-->";

        #endregion

        public static string gen(string strDstDirPath, string strDstDirPathPrefix)
        {
            //1.get template
            var strFilePathTemplate = _getFilePathTemplate();
            var strTemplate = File.ReadAllText(strFilePathTemplate);
            
            //2.获得strDstDirPath下js列表
            var lstFileInfo = new List<FileInfo>();
            FileUtils.getFilesInDir(strDstDirPath, PREFIX_FILE, ref lstFileInfo);

            //3.遍历，生成
            var strContent = "";
            foreach (var oFileInfo in lstFileInfo)
            {
                if (oFileInfo.FullName.Contains(_getIgnoreName()))
                {
                    continue;
                }

                var strFilePathJS = oFileInfo.FullName;
                var strPosFilePathJS = oFileInfo.FullName.Replace(strDstDirPathPrefix, string.Empty).Replace(@"\", @"/");
                strContent += strTemplate.Replace(REPLACE_PATH, strPosFilePathJS);
                if (lstFileInfo.Last() != oFileInfo)
                {
                    strContent += Environment.NewLine;
                }
            }

            return strContent;
        }
    }
}
