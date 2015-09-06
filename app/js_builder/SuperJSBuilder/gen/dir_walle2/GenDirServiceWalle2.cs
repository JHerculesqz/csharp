using SuperJSBuilder.utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperJSBuilder.gen.dir_walle2
{
    class GenDirServiceWalle2
    {
        public static void gen(string strSrcDirPath)
        {
            Console.WriteLine("==============DirServiceWalle2 start====================");
            GenDirAdapter._genByType(strSrcDirPath, "core");
            GenDirAdapter._genByType(strSrcDirPath, "component");
            GenDirAdapter._genByType(strSrcDirPath, "widget");
            Console.WriteLine("==============DirServiceWalle2 end====================");
        }
    }
}
