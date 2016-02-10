using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace walle.utils
{
    public class LogUtils
    {
        #region debug

        public static void debug(string strTitle, string strContent)
        {
            Console.WriteLine("{0}[{1}]{2}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), strTitle, strContent);
        }

        #endregion

        #region info

        public static void info(string strTitle, string strContent)
        {
            Console.WriteLine("{0}[{1}]{2}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), strTitle, strContent);
        }

        #endregion
    }
}
