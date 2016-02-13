using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nbuild
{
    public class SolutionServicePlugin
    {
        #region get

        public static string getDirPathSolution()
        {
            return new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
        }

        #endregion
    }
}
