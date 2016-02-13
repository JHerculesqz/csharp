using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace walle.utils
{
    /// <summary>
    /// 参考：
    /// http://www.cnblogs.com/x4646/archive/2013/04/11/3014634.html
    /// </summary>
    public class WebUtils
    {
        #region downloadFile

        public static void downloadFile(string strUrl, string strFilePathDst)
        {
            WebClient oWebClient = new WebClient();
            oWebClient.DownloadFile(strUrl, strFilePathDst);
        }

        #endregion
    }
}
