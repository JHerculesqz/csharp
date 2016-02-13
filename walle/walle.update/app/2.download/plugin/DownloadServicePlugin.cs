using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace walle.update
{
    public class DownloadServicePlugin
    {
        #region Const

        public static string FILE_PATH_TMP_XML = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"data\walle.udate\updateInfo.xml");

        private static string PROP_VERSION = "version";
        private static string PROP_URL_UPDATE_ZIP = "urlUpdateZip";
        
        #endregion

        #region parse

        public static UpdateInfo parse()
        {
            var oDoc = XElement.Load(FILE_PATH_TMP_XML);
            var strVersion = oDoc.Element(PROP_VERSION).Value;
            var strUrlUpdateZip = oDoc.Element(PROP_URL_UPDATE_ZIP).Value;
            var oUpdateInfo = new UpdateInfo();
            oUpdateInfo.Version = strVersion;
            oUpdateInfo.UrlUpdateZip = strUrlUpdateZip;

            return oUpdateInfo;
        }

        #endregion
    }
}
