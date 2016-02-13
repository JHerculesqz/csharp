using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using walle.utils;

namespace walle.update
{
    public class ClearService
    {
        #region clear

        public void clear()
        {
            LogUtils.debug("ClearService.clear", "start...");

            DirUtils.del(ClearServicePlugin.DIR_PATH_TMP);

            LogUtils.debug("ClearService.clear", "end...");
        }

        #endregion
    }
}
