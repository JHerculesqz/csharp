using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using walle.utils;

namespace SuperYF
{
    public class Step2Service
    {
        #region createFilePathRawData

        public void createFilePathRawData(
            string strCompanyName, 
            string strDirPathRoot,
            string strRawDataTree,
            string strRawDataName,
            string strRawDataType)
        {
            LogUtils.info("Step2Service", "createFilePathRawData start...");

            var strFilePathRawData = Step2ServicePlugin._refreshFilePathRawData(
                strCompanyName,
                strDirPathRoot,
                strRawDataTree,
                strRawDataName);

            Step2ServicePlugin._createFilePathRawData(strFilePathRawData, strRawDataType);

            LogUtils.info("Step2Service", "createFilePathRawData end...");
        }

        #endregion
    }
}
