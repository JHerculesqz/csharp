using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperJSBuilder.utils
{
    interface IMergeDirAdapter
    {
        string getDstDirPath(string strSrcDirPath);
    }
}
