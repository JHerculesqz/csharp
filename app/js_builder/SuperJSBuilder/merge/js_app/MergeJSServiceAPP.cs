using SuperJSBuilder.utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperJSBuilder.merge.js_app
{
    class MergeJSServiceAPP
    {
        public static void merge(string strSrcDirPath)
        {
            Console.WriteLine("========================MergeJSServiceAPP start=========================");
            var strContent = MergeJSAdapter.merge(strSrcDirPath, "", new MergeJSAdaterAPP());
            MergeJSAdapter.minify(strSrcDirPath, strContent, new MergeJSAdaterAPP());
            Console.WriteLine("========================MergeJSServiceAPP end=========================");
        }
    }

    class MergeJSAdaterAPP : IMergeJSAdapter
    {
        public string getSrcDirPathJS(string strSrcDirPath, string strSubDirName)
        {
            return Path.Combine(strSrcDirPath, strSubDirName);
        }

        public string getIgnoreName()
        {
            return "\\bin\\";
        }

        public string getDstFilePathJS(string strSrcDirPath)
        {
            return Path.Combine(strSrcDirPath, "bin/js/app.js");
        }

        public string getDstFilePathMinJS(string strSrcDirPath)
        {
            return Path.Combine(strSrcDirPath, "bin/js/app.min.js");
        }
    }
}
