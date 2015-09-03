using SuperJSBuilder.utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperJSBuilder.gen.dir_walle2
{
    class DirServiceWalle2
    {
        public static void gen(string strSrcDirPath)
        {
            Console.WriteLine("==============DirServiceWalle2 start====================");
            DirService._genByType(strSrcDirPath, "core");
            DirService._genByType(strSrcDirPath, "component");
            DirService._genByType(strSrcDirPath, "widget");
            Console.WriteLine("==============DirServiceWalle2 end====================");
        }
    }
}
