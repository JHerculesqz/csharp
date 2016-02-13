using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using walle.utils;

namespace SuperDocBuilder
{
    public class CopyService
    {
        #region copy

        public void copy()
        {
            LogUtils.debug("SuperDocBuilder.CopyService", "start...");

            //1.rmdir
            var strDirPathSrc = CopyServicePlugin.DIR_PATH_SRC;
            var strDirPathDst = CopyServicePlugin.DIR_PATH_DST(MainService.getInstance().m_oConfService.Confs[ConfServicePlugin.PROP_dirPathBase]);
            if (Directory.Exists(strDirPathDst))
            {
                DirUtils.del(strDirPathDst);
            }

            //2.xcopy
            FileUtils.xcopy(strDirPathSrc, strDirPathDst);

            LogUtils.debug("SuperDocBuilder.CopyService", "end...");
        }

        #endregion
    }
}
