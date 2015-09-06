using SuperJSBuilder.utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperJSBuilder.gen.js_walle2
{
    class GenJSServiceWalle2
    {
        public static void gen(string strSrcDirPath)
        {
            Console.WriteLine("==============JSServiceWalle2 start====================");
            GenFileAdapterJS._genByType(strSrcDirPath, "core", new FileAdapterJSWalle2());
            GenFileAdapterJS._genByType(strSrcDirPath, "component", new FileAdapterJSWalle2());
            GenFileAdapterJS._genByType(strSrcDirPath, "widget", new FileAdapterJSWalle2());
            Console.WriteLine("==============JSServiceWalle2 end====================");
        }
    }

    #region FileAdapterJSWalle2

    class FileAdapterJSWalle2 : IGenFileAdapterJS
    {
        #region Const

        private static string PREFIX_NAME_DST = "CHNB";

        private static string FILE_PATH_TEMPLATE_JS()
        {
            var strFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data/SuperJSBuilder/js_walle2/template.js");
            return strFilePath;
        }

        private static string FILE_PATH_DST_JS(string strSrcDirPath, string strSubDirPath, string strModuleName)
        {
            var strFilePath = Path.Combine(Path.Combine(Path.Combine(Path.Combine(strSrcDirPath, strSubDirPath), strModuleName), "js"), strModuleName + ".js");
            return strFilePath;
        }

        #endregion

        public string getPrefixName()
        {
            return PREFIX_NAME_DST;
        }

        public string getTemplateFilePath()
        {
            return FILE_PATH_TEMPLATE_JS();
        }

        public string getDstFilePath(string strSrcDirPath, string strSubDirPath, string strModuleName)
        {
            return FILE_PATH_DST_JS(strSrcDirPath, strSubDirPath, strModuleName);
        }
    }

    #endregion
}
