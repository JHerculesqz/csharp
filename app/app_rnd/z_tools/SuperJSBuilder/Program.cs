using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperJSBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.config init
            ConfigAdapter.init();

            //2.wall2
            //2.1.gen
            GenDirServiceWalle2.gen(ConfigAdapter.getValue4WallE(ConfigAdapter.KEY_SRC_DIR_PATH));
            GenLessServiceWalle2.gen(ConfigAdapter.getValue4WallE(ConfigAdapter.KEY_SRC_DIR_PATH));
            GenJSServiceWalle2.gen(ConfigAdapter.getValue4WallE(ConfigAdapter.KEY_SRC_DIR_PATH));
            //2.2.merge
            MergeDirServiceWalle.merge(ConfigAdapter.getValue4WallE(ConfigAdapter.KEY_SRC_DIR_PATH));
            MergeImageServiceWalle2.merge(ConfigAdapter.getValue4WallE(ConfigAdapter.KEY_SRC_DIR_PATH));
            MergeJSServiceWalle2.merge(ConfigAdapter.getValue4WallE(ConfigAdapter.KEY_SRC_DIR_PATH));
            MergeLessServiceWalle.merge(ConfigAdapter.getValue4WallE(ConfigAdapter.KEY_SRC_DIR_PATH));

            //3.app
            //3.1.gen
            GenDirServiceApp.gen(ConfigAdapter.getValue4App(ConfigAdapter.KEY_SRC_DIR_PATH));
            GenLessServiceApp.gen(ConfigAdapter.getValue4App(ConfigAdapter.KEY_SRC_DIR_PATH));
            GenJSServiceApp.gen(ConfigAdapter.getValue4App(ConfigAdapter.KEY_SRC_DIR_PATH));
            GenJSServiceMockReg.gen(ConfigAdapter.getValue4App(ConfigAdapter.KEY_SRC_DIR_PATH),
                ConfigAdapter.getValue4App(ConfigAdapter.KEY_MOCK_REG_LEVEL),
                ConfigAdapter.getValue4App(ConfigAdapter.KEY_MOCK_REG_IS_CHECK),
                ConfigAdapter.getValue4App(ConfigAdapter.KEY_MOCK_REG_IS_ENV_MOCK));
            MergeDirServiceAPP.merge(ConfigAdapter.getValue4App(ConfigAdapter.KEY_SRC_DIR_PATH));
            MergeImageServiceAPP.merge(ConfigAdapter.getValue4App(ConfigAdapter.KEY_SRC_DIR_PATH));
            MergeJSServiceAPP.merge(ConfigAdapter.getValue4App(ConfigAdapter.KEY_SRC_DIR_PATH));
            MergeLessServiceAPP.merge(ConfigAdapter.getValue4App(ConfigAdapter.KEY_SRC_DIR_PATH));
            GenHtmlServiceAPP.gen(ConfigAdapter.getValue4App(ConfigAdapter.KEY_SRC_DIR_PATH),
                ConfigAdapter.getValue4App(ConfigAdapter.KEY_REPLACE_DIR_PATH));
            GenHtmlMinServiceAPP.gen(ConfigAdapter.getValue4App(ConfigAdapter.KEY_SRC_DIR_PATH),
                ConfigAdapter.getValue4App(ConfigAdapter.KEY_APP_NAME));
            GenHtmlJSPServiceAPP.gen(ConfigAdapter.getValue4App(ConfigAdapter.KEY_SRC_DIR_PATH),
                ConfigAdapter.getValue4App(ConfigAdapter.KEY_APP_NAME));

            Console.ReadLine();
        }
    }
}
