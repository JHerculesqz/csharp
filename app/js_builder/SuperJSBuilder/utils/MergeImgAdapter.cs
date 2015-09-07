using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using walle.utils;

namespace SuperJSBuilder.utils
{
    class MergeImgAdapter
    {
        #region Const

        private static string IMG_TYPE_PNG = ".png";
        private static string IMG_TYPE_CUR = ".cur";

        #endregion

        public static void merge(string strSrcDirPath, string strSubDirName, IMergeImageAdapter oIMergeImageAdapter)
        {
            //0.get srcDirPath
            var strSrcDirPathImg = oIMergeImageAdapter.getSrcDirPathImg(strSrcDirPath, strSubDirName);

            //1.get all image files
            var lstImgInDir = new List<FileInfo>();
            FileUtils.getFilesInDir(strSrcDirPathImg, IMG_TYPE_PNG, ref lstImgInDir);
            FileUtils.getFilesInDir(strSrcDirPathImg, IMG_TYPE_CUR, ref lstImgInDir);

            foreach (var oFileImg in lstImgInDir)
            {
                if (!string.IsNullOrEmpty(oIMergeImageAdapter.getIgnoreName()))
                {
                    if (oFileImg.FullName.Contains(oIMergeImageAdapter.getIgnoreName()))
                    {
                        continue;
                    }
                }

                //2.get strDstFilePathImg
                var strDstFilePathImg = oIMergeImageAdapter.getDstFilePathImg(strSrcDirPath, oFileImg.Name);

                //3.copy
                File.Copy(oFileImg.FullName, strDstFilePathImg, true);
                Console.WriteLine(new FileInfo(strDstFilePathImg).Name);
            }
        }
    }
}
