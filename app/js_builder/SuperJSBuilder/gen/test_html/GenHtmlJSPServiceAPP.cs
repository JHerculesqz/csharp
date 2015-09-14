using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperJSBuilder.gen.test_html
{
    class GenHtmlJSPServiceAPP
    {
        #region Const

        private static string _getFilePathTemplate()
        {
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data/SuperJSBuilder/html_app/test_app.jsp");
        }

        private static void _insertTo(string strContent, string strStartTag, string strEndTag, ref string strTemplate)
        {
            var iStartIndex = strTemplate.IndexOf(strStartTag) + strStartTag.Length;
            var iEndIndex = strTemplate.IndexOf(strEndTag);
            var iCount = iEndIndex - iStartIndex;
            strTemplate = strTemplate.Remove(iStartIndex, iCount);
            strTemplate = strTemplate.Insert(iStartIndex, Environment.NewLine + strContent + Environment.NewLine);
        }

        private static string _getFilePathDst(string strSrcDirPath)
        {
            return Path.Combine(strSrcDirPath, "bin/test_app_min.jsp");
        }

        private static string _replaceContent(string strContent)
        {
            return strContent.Replace("../../../", "ipps/");
        }

        #endregion

        public static void gen(string strSrcDirPath, string strAppName)
        {
            Console.WriteLine("====================GenHtmlJSPServiceAPP start===========================");

            //1.css_lib
            var strCssLibContent = GenCssLibAdapter.gen();
            strCssLibContent = _replaceContent(strCssLibContent);

            //2.css_app
            var strCssAppContent = GenCssAppAdapter.gen4Min(strAppName);
            strCssAppContent = _replaceContent(strCssAppContent);

            //3.js_lib
            var strJSLibContent = GenJSLibAdapter.gen();
            strJSLibContent = _replaceContent(strJSLibContent);

            //4.js_app
            var strJSAppContent = GenJSAppAdapter.gen4min(strAppName);

            //5.require_app
            var strJSAppRequireContent = GenJSModuleAppAdapter.genModule(strSrcDirPath);

            //6.insertTo
            var strTemplateHtml = File.ReadAllText(_getFilePathTemplate());
            if (File.Exists(_getFilePathDst(strSrcDirPath)))
            {
                strTemplateHtml = File.ReadAllText(_getFilePathDst(strSrcDirPath));
            }
            _insertTo(strCssLibContent, GenCssLibAdapter.START_TAG, GenCssLibAdapter.END_TAG, ref strTemplateHtml);
            _insertTo(strCssAppContent, GenCssAppAdapter.START_TAG, GenCssAppAdapter.END_TAG, ref strTemplateHtml);
            _insertTo(strJSLibContent, GenJSLibAdapter.START_TAG, GenJSLibAdapter.END_TAG, ref strTemplateHtml);
            _insertTo(strJSAppContent, GenJSAppAdapter.START_TAG, GenJSAppAdapter.END_TAG, ref strTemplateHtml);
            _insertTo(strJSAppRequireContent, GenJSModuleAppAdapter.START_TAG, GenJSModuleAppAdapter.END_TAG, ref strTemplateHtml);
            File.WriteAllText(_getFilePathDst(strSrcDirPath), strTemplateHtml);

            Console.WriteLine("====================GenHtmlJSPServiceAPP end===========================");
        }
    }
}
