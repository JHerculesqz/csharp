using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using walle.utils;

namespace SuperDocBuilder
{
    public class MergeService
    {
        #region merge

        public void merge()
        {
            LogUtils.debug("MergeService.merge", "start...");

            //1.get strDirPathBase
            var strDirPathBase = MainService.getInstance().m_oConfService.Confs[ConfServicePlugin.PROP_dirPathBase];

            //2.解析walle.prj,获得lstModule
            if (!File.Exists(MergeServicePlugin.FILE_PATH_walle(strDirPathBase)))
            {
                LogUtils.debug("MergeService.copy", "walle.prj not exists...");
                return;
            }
            var lstModule = File.ReadAllLines(MergeServicePlugin.FILE_PATH_walle(strDirPathBase));

            //3.遍历lstModule,构造strMarkDown
            var strMarkDown = "";
            foreach (var strModule in lstModule)
            {
                //3.1.根据strModule，获得strFilePathModuleMD
                var strDirPathModuleMD = MergeServicePlugin.DIR_PATH_module(strDirPathBase, strModule);
                var lstFileInDirecotry = new List<FileInfo>();
                FileUtils.getFilesInDir(strDirPathModuleMD, ".md", ref lstFileInDirecotry);
                if (lstFileInDirecotry.Count != 1)
                {
                    LogUtils.debug("MergeService.copy", strModule + ".md not exists...");
                    return;
                }
                var strFilePathModuleMD = lstFileInDirecotry.First().FullName;

                //3.2.merge md
                strMarkDown += File.ReadAllText(strFilePathModuleMD) + Environment.NewLine;

                //3.3.merge image
                var strDirPathModuleImg = MergeServicePlugin.DIR_PATH_module_image(strDirPathBase, strModule);
                var lstFileInDirecotryImg = new List<FileInfo>();
                FileUtils.getFilesInDir(strDirPathModuleImg, ".txt", ref lstFileInDirecotryImg);
                foreach (var oFileInfoImg in lstFileInDirecotryImg)
                {
                    PlantUMLUtils.toImg(oFileInfoImg.FullName);
                }
                var strDirPathSrc = MergeServicePlugin.DIR_PATH_module_image(strDirPathBase, strModule);
                var strDirPathDst = MergeServicePlugin.DIR_PATH_output_image(strDirPathBase);
                FileUtils.xcopy(strDirPathSrc, strDirPathDst);
            }

            //4.SaveFile
            File.WriteAllText(MergeServicePlugin.FILE_PATH_output_md(strDirPathBase), strMarkDown);

            LogUtils.debug("MergeService.merge", "end...");
        }

        #endregion
    }
}
