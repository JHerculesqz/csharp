using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SuperJSBuilder.utils
{
    class ConfigService
    {
        #region Const

        private static string FILE_PATH_CONF = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data/SuperJSBuilder/params.xml");
        private static string PROP_PARAMS = "params";
        private static string PROP_PARAM = "param";
        private static string PROP_PARAM_KEY = "key";

        public static string KEY_TYPE = "type";
        public static string KEY_SRC_DIR_PATH = "srcDirPath";
        public static string KEY_MERGE_NAME = "mergeName";
        public static string KEY_REPLACE_DIR_PATH = "replaceDirPath";
        public static string KEY_MOCK_REG_LEVEL = "mockRegLevel";

        public static string TYPE_WALLE2 = "walle2";
        public static string TYPE_APP = "app";

        #endregion

        #region Fields

        private static Dictionary<string, string> m_mapConf = new Dictionary<string, string>();

        #endregion

        #region init

        public static void init()
        {
            var oDoc = XElement.Load(FILE_PATH_CONF);
            var lstParamEle = oDoc.Elements(PROP_PARAMS);
            foreach (var oParamEle in lstParamEle)
            {
                var strKey = oParamEle.Attribute(PROP_PARAM_KEY).Value;
                var strValue = oParamEle.Value;
                m_mapConf.Add(strKey, strValue);
            }
        }

        #endregion

        #region getValue

        public static string getValue(string strKey)
        {
            return m_mapConf[strKey];
        }

        #endregion
    }
}
