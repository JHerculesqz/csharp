using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using walle.utils;

namespace SuperDocBuilder
{
    public class ConfService
    {
        #region Const

        private static string FILE_PATH_CONF = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data/SuperDocBuilder/conf.xml");

        #endregion

        #region Fields

        private Dictionary<string, string> confs = new Dictionary<string, string>();

        public Dictionary<string, string> Confs
        {
            get { return confs; }
            set { confs = value; }
        }

        #endregion

        #region load

        public void load()
        {
            LogUtils.debug("ConfService.load", "start...");

            var oDoc = XElement.Load(FILE_PATH_CONF);
            foreach (var oEle in oDoc.Elements())
            {
                confs.Add(oEle.Name.ToString(), oEle.Value);
            }

            LogUtils.debug("ConfService.load", "end...");
        }

        #endregion

        #region save

        public void save(string strDirPathBase)
        {
            var oDoc = XElement.Load(FILE_PATH_CONF);
            oDoc.Element(ConfServicePlugin.PROP_dirPathBase).Value = strDirPathBase;
            oDoc.Save(FILE_PATH_CONF);
        }

        #endregion
    }
}
