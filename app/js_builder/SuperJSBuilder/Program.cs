using SuperJSBuilder.gen.dir_app;
using SuperJSBuilder.gen.dir_walle2;
using SuperJSBuilder.gen.js_app;
using SuperJSBuilder.gen.js_walle2;
using SuperJSBuilder.gen.less_app;
using SuperJSBuilder.gen.less_walle2;
using SuperJSBuilder.gen.mock_reg;
using SuperJSBuilder.merge.dir_app;
using SuperJSBuilder.merge.dir_walle2;
using SuperJSBuilder.merge.image_app;
using SuperJSBuilder.merge.image_walle2;
using SuperJSBuilder.merge.js_app;
using SuperJSBuilder.merge.js_walle2;
using SuperJSBuilder.merge.less_walle2;
using SuperJSBuilder.utils;
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

            Console.ReadLine();
        }
    }
}
