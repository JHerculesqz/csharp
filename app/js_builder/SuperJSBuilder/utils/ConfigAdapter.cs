using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SuperJSBuilder.utils
{
    class ConfigAdapter
    {
        #region Const

        private static string FILE_PATH_CONF = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data/SuperJSBuilder/params.xml");
        private static string PROP_TASK = "task";
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

        private static ConfigServiceVo m_oConfigServiceVoWallE2 = new ConfigServiceVo();
        private static ConfigServiceVo m_oConfigServiceVoApp = new ConfigServiceVo();

        #endregion

        #region init

        public static void init()
        {
            var oDoc = XElement.Load(FILE_PATH_CONF);
            var lstTaskEle = oDoc.Elements(PROP_TASK);
            foreach (var oTaskEle in lstTaskEle)
            {
                var lstParamEle = oTaskEle.Elements(PROP_PARAM);
                foreach (var oParamEle in lstParamEle)
                {
                    var strKey = oParamEle.Attribute(PROP_PARAM_KEY).Value;
                    var strValue = oParamEle.Value;
                    if (lstTaskEle.First().Equals(oTaskEle))
                    {
                        m_oConfigServiceVoWallE2.Configs.Add(strKey, strValue);
                    }
                    else
                    {
                        m_oConfigServiceVoApp.Configs.Add(strKey, strValue);
                    }
                }
            }
        }

        #endregion

        #region getValue

        public static string getValue4WallE(string strKey)
        {
            return m_oConfigServiceVoWallE2.Configs[strKey];
        }

        public static string getValue4App(string strKey)
        {
            return m_oConfigServiceVoApp.Configs[strKey];
        }

        #endregion
    }

    public class ConfigServiceVo
    {
        #region Fields

        private Dictionary<string, string> configs = new Dictionary<string, string>();

        public Dictionary<string, string> Configs
        {
            get { return configs; }
            set { configs = value; }
        }

        #endregion
    }
}
