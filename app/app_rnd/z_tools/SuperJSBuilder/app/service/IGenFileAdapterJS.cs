using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperJSBuilder
{
    interface IGenFileAdapterJS
    {
        string getPrefixName();

        string getTemplateFilePath();

        string getDstFilePath(string strSrcDirPath, string strSubDirPath, string strModuleName);
    }
}
