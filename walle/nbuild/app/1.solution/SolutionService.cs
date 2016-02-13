using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using walle.utils;

namespace nbuild
{
    public class SolutionService
    {
        #region getDirPathSolution

        public string getDirPathSolution()
        {
            LogUtils.debug("SolutionService.getDirPathSolution", "start...");

            return SolutionServicePlugin.getDirPathSolution();

            LogUtils.debug("SolutionService.getDirPathSolution", "end...");
        }

        #endregion
    }
}
