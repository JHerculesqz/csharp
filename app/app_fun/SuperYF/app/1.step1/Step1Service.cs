using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using walle.utils;

namespace SuperYF
{
    public class Step1Service
    {
        #region createDirPath

        public void createDirPath(string strCompanyName, string strDirPathRoot)
        {
            LogUtils.info("Step1Service", "createDirPath start...");

            Step1ServicePlugin._createDirPath(strCompanyName, strDirPathRoot);

            LogUtils.info("Step1Service", "createDirPath end...");
        }

        #endregion

        #region getDirPathRawData

        public string getDirPathRawData(string strCompanyName, string strDirPathRoot)
        {
            return Step1ServicePlugin.DIR_PATH_rawData(strCompanyName, strDirPathRoot);
        }

        #endregion
    }
}
