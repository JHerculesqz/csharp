using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using walle.utils;

namespace SuperDocBuilder
{
    public class BuildService
    {
        #region build

        public void build()
        {
            LogUtils.debug("BuildService.build", "start...");

            ProcessUtils.openAppByBlockAndEnv(BuildServicePlugin.FILE_PATH_build_bat(MainService.getInstance().m_oConfService.Confs[ConfServicePlugin.PROP_dirPathBase]), "");

            LogUtils.debug("BuildService.build", "end...");
        }

        #endregion
    }
}
