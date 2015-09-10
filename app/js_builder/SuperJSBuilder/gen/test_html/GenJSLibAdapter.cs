using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperJSBuilder.gen.test_html
{
    class GenJSLibAdapter
    {
        #region Const

        public static string START_TAG = "<!--js.lib start-->";
        public static string END_TAG = "<!--js.lib end-->";

        #endregion

        public static string gen()
        {
            var strFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data/SuperJSBuilder/html_app/js_lib.txt");
            var strContent = File.ReadAllText(strFilePath);
            return strContent;
        }
    }
}
