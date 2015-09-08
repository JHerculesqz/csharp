﻿using SuperJSBuilder.utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperJSBuilder.merge.less_walle2
{
    class MergeLessServiceAPP
    {
        public static void merge(string strSrcDirPath)
        {
            Console.WriteLine("========================MergeLessServiceAPP start=========================");
            var strContent = MergeLessAdapter.merge(strSrcDirPath, "", new MergeLessAdaterAPP());
            MergeLessAdapter.minify(strSrcDirPath, strContent, new MergeLessAdaterAPP());
            Console.WriteLine("========================MergeLessServiceAPP end=========================");
        }
    }

    class MergeLessAdaterAPP : IMergeLessAdapter
    {
        public string getSrcDirPathLess(string strSrcDirPath, string strSubDirName)
        {
            return Path.Combine(strSrcDirPath, strSubDirName);
        }

        public string getIgnoreName()
        {
            return "\\bin\\";
        }

        public string getDstFilePathLess(string strSrcDirPath)
        {
            return Path.Combine(strSrcDirPath, "bin/less/app.less");
        }

        public string getDstFilePathMinLess(string strSrcDirPath)
        {
            return Path.Combine(strSrcDirPath, "bin/less/app.min.css");
        }
    }
}