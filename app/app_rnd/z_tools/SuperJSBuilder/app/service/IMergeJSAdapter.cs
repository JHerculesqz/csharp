using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperJSBuilder
{
    interface IMergeJSAdapter
    {
        string getSrcDirPathJS(string strSrcDirPath, string strSubDirName);

        string getIgnoreName();

        string getDstFilePathJS(string strSrcDirPath);

        string getDstFilePathMinJS(string strSrcDirPath);
    }
}
