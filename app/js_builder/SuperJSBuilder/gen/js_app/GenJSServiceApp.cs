using SuperJSBuilder.utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperJSBuilder.gen.js_app
{
    class GenJSServiceApp
    {
        public static void gen(string strSrcDirPath)
        {
            Console.WriteLine("==============JSServiceAPP start====================");
            GenFileAdapterJS._genByType(strSrcDirPath, "", new FileAdapterJSAppJS());
            GenFileAdapterJS._genByType(strSrcDirPath, "", new FileAdapterJSAppMainJS());
            GenFileAdapterJS._genByType(strSrcDirPath, "", new FileAdapterJSAppMockJS());
            GenFileAdapterJS._genByType(strSrcDirPath, "", new FileAdapterJSAppRegJS());
            Console.WriteLine("==============JSServiceAPP end====================");
        }
    }

    #region FileAdapterJSAppJS

    class FileAdapterJSAppJS : IGenFileAdapterJS
    {
        #region Const

        private static string PREFIX_NAME_DST = "";

        private static string FILE_PATH_TEMPLATE_JS()
        {
            var strFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data/SuperJSBuilder/js_app/template.js");
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

    #region FileAdapterJSAppMainJS

    class FileAdapterJSAppMainJS : IGenFileAdapterJS
    {
        #region Const

        private static string PREFIX_NAME_DST = "";

        private static string FILE_PATH_TEMPLATE_JS()
        {
            var strFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data/SuperJSBuilder/js_app/template_main.js");
            return strFilePath;
        }

        private static string FILE_PATH_DST_JS(string strSrcDirPath, string strSubDirPath, string strModuleName)
        {
            var strFilePath = Path.Combine(Path.Combine(Path.Combine(Path.Combine(strSrcDirPath, strSubDirPath), strModuleName), "js"), strModuleName + "_main.js");
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

    #region FileAdapterJSAppMockJS

    class FileAdapterJSAppMockJS : IGenFileAdapterJS
    {
        #region Const

        private static string PREFIX_NAME_DST = "";

        private static string FILE_PATH_TEMPLATE_JS()
        {
            var strFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data/SuperJSBuilder/js_app/template_mock.js");
            return strFilePath;
        }

        private static string FILE_PATH_DST_JS(string strSrcDirPath, string strSubDirPath, string strModuleName)
        {
            var strFilePath = Path.Combine(Path.Combine(Path.Combine(Path.Combine(strSrcDirPath, strSubDirPath), strModuleName), "js"), strModuleName + "_mock.js");
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

    #region FileAdapterJSAppRegJS

    class FileAdapterJSAppRegJS : IGenFileAdapterJS
    {
        #region Const

        private static string PREFIX_NAME_DST = "";

        private static string FILE_PATH_TEMPLATE_JS()
        {
            var strFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data/SuperJSBuilder/js_app/template_reg.js");
            return strFilePath;
        }

        private static string FILE_PATH_DST_JS(string strSrcDirPath, string strSubDirPath, string strModuleName)
        {
            var strFilePath = Path.Combine(Path.Combine(Path.Combine(Path.Combine(strSrcDirPath, strSubDirPath), strModuleName), "js"), strModuleName + "_reg.js");
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
