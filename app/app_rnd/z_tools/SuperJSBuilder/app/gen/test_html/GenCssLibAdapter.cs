using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperJSBuilder
{
    class GenCssLibAdapter
    {
        #region Const

        public static string START_TAG = "<!--css.lib start-->";
        public static string END_TAG = "<!--css.lib end-->";

        #endregion

        public static string gen()
        {
            var strFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data/SuperJSBuilder/html_app/css_lib.txt");
            var strContent = File.ReadAllText(strFilePath);
            return strContent;
        }
    }
}
