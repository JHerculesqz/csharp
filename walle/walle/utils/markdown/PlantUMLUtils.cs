using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace walle.utils
{
    public class PlantUMLUtils
    {
        #region Const

        private static string FILE_PATH = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"data\walle\plantuml\plantuml.jar");

        #endregion

        #region toImg

        public static void toImg(string strFilePathImg)
        {
            ProcessUtils.openAppByBlockAndEnv("java", string.Format("-jar {0} {1}", FILE_PATH, strFilePathImg));
        }

        #endregion
    }
}
