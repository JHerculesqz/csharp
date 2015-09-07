using SuperJSBuilder.utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using walle.utils;

namespace SuperJSBuilder.gen.mock_reg
{
    class GenJSServiceMockReg
    {
        #region Const

        private static string FILE_PATH_PRJ_IN_X(string strSrcDirPath, string strSubDirPath)
        {
            return Path.Combine(Path.Combine(strSrcDirPath, strSubDirPath), "walle.prj");
        }

        private static string FILE_PATH_TEMPLATE()
        {
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data/SuperJSBuilder/mock_reg/mock_reg.js");
        }

        private static string FILE_PATH_TEMPLATE_PART()
        {
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data/SuperJSBuilder/mock_reg/mock_reg_part.js");
        }

        private static string FILE_PATH_DST(string strSrcDirPath, string strSubDirPath)
        {
            return Path.Combine(Path.Combine(strSrcDirPath, strSubDirPath), "mock_reg.js");
        }

        private static string REPLACE_MODULE_NAME = "MODULENAME";
        private static string REPLACE_MODULELEVEL = "MODULELEVEL";
        private static string REPLACE_MODULEISCHECK = "MODULEISCHECK";
        private static string REPLACE_MODULEISENVMOCK = "MODULEISENVMOCK";
        private static string REPLACE_MODULEJSONS = "MODULEJSONS";

        #endregion

        public static void gen(string strSrcDirPath, string strLevel, string strIsCheck, string strIsEnvMock)
        {
            Console.WriteLine("==============GenJSServiceMockReg start====================");

            //1.get template
            var strTemplate = File.ReadAllText(FILE_PATH_TEMPLATE());
            var strTemplatePart = File.ReadAllText(FILE_PATH_TEMPLATE_PART());

            //2.generate parts
            var arrLines = File.ReadAllLines(FILE_PATH_PRJ_IN_X(strSrcDirPath, ""));
            var strParts = "";
            foreach (var strModuleName in arrLines)
            {
                var strFormatModuleName = ModuleNameAdapter.formatName(strModuleName, "");
                var strTmp = strTemplatePart.Replace(REPLACE_MODULE_NAME, strFormatModuleName)
                    .Replace(REPLACE_MODULELEVEL, strLevel)
                    .Replace(REPLACE_MODULEISCHECK, strIsCheck)
                    .Replace(REPLACE_MODULEISENVMOCK, strIsEnvMock);
                if (arrLines.Last() != strModuleName)
                {
                    strTmp += "," + Environment.NewLine;
                }
                strParts += strTmp;
            }

            //3.generate template
            var strRes = strTemplate.Replace(REPLACE_MODULEJSONS, strParts);

            //4.write file
            File.WriteAllText(FILE_PATH_DST(strSrcDirPath, ""), strRes);

            Console.WriteLine("==============GenJSServiceMockReg end====================");
        }
    }
}
