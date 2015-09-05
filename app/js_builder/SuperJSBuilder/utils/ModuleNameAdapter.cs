using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using walle.utils;

namespace SuperJSBuilder.utils
{
    class ModuleNameAdapter
    {
        #region Const

        private static string SEPERATOR = "_";

        #endregion

        public static string formatName(string strModuleName, string strPrefix)
        {
            string strFormatName = strPrefix;

            List<string> lstWord = strModuleName.Split(SEPERATOR.ToCharArray()).ToList();
            foreach (var strWord in lstWord)
            {
                strFormatName += StringUtils.toTitleCase(strWord);
            }

            return strFormatName;
        }
    }
}
