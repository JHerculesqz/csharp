using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace walle.utils
{
    public class DirUtils
    {
        #region del

        public static void del(string strDirPath)
        {
            try
            {
                Directory.Delete(strDirPath, true);
            }
            catch(Exception ex){
                LogUtils.error("DirUtils.del", ex.Message);
            }
        }

        #endregion
    }
}
