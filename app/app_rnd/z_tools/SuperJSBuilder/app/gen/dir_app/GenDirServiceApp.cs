using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperJSBuilder
{
    class GenDirServiceApp
    {
        public static void gen(string strSrcDirPath)
        {
            Console.WriteLine("==============GenDirServiceApp start====================");
            GenDirAdapter._genByType(strSrcDirPath, "");
            Console.WriteLine("==============GenDirServiceApp end====================");
        }
    }
}
