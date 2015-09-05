using SuperJSBuilder.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperJSBuilder.gen.dir_app
{
    class DirServiceApp
    {
        public static void gen(string strSrcDirPath)
        {
            Console.WriteLine("==============DirServiceApp start====================");
            GenDirAdapter._genByType(strSrcDirPath, "");
            Console.WriteLine("==============DirServiceApp end====================");
        }
    }
}
