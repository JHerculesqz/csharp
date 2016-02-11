using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperJSBuilder
{
    class MergeDirServiceWalle
    {
        public static void merge(string strSrcDirPath)
        {
            Console.WriteLine("========================MergeDirServiceWalle start=======================");
            MergeDirAdapter.mergeByType(strSrcDirPath, new MergeDirAdapterWallE());
            Console.WriteLine("========================MergeDirServiceWalle end=======================");
        }
    }

    class MergeDirAdapterWallE : IMergeDirAdapter
    {
        public string getDstDirPath(string strSrcDirPath)
        {
            return Path.Combine(new DirectoryInfo(strSrcDirPath).Parent.FullName, "lib/walle2");
        }
    }
}
