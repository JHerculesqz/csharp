using SuperJSBuilder.gen.dir_app;
using SuperJSBuilder.gen.dir_walle2;
using SuperJSBuilder.gen.js_app;
using SuperJSBuilder.gen.js_walle2;
using SuperJSBuilder.gen.less_app;
using SuperJSBuilder.gen.less_walle2;
using SuperJSBuilder.gen.mock_reg;
using SuperJSBuilder.merge.walle2;
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
            DirServiceWalle2.gen(ConfigAdapter.getValue4WallE(ConfigAdapter.KEY_SRC_DIR_PATH));
            LessServiceWalle2.gen(ConfigAdapter.getValue4WallE(ConfigAdapter.KEY_SRC_DIR_PATH));
            JSServiceWalle2.gen(ConfigAdapter.getValue4WallE(ConfigAdapter.KEY_SRC_DIR_PATH));
            //2.2.merge
            MergeServiceWalle2.merge();

            //3.app
            //3.1.gen
            DirServiceApp.gen(ConfigAdapter.getValue4App(ConfigAdapter.KEY_SRC_DIR_PATH));
            LessServiceApp.gen(ConfigAdapter.getValue4App(ConfigAdapter.KEY_SRC_DIR_PATH));
            JSServiceApp.gen(ConfigAdapter.getValue4App(ConfigAdapter.KEY_SRC_DIR_PATH));
            JSServiceMockReg.gen(ConfigAdapter.getValue4App(ConfigAdapter.KEY_SRC_DIR_PATH),
                ConfigAdapter.getValue4App(ConfigAdapter.KEY_MOCK_REG_LEVEL),
                ConfigAdapter.getValue4App(ConfigAdapter.KEY_MOCK_REG_IS_CHECK),
                ConfigAdapter.getValue4App(ConfigAdapter.KEY_MOCK_REG_IS_ENV_MOCK));

            Console.ReadLine();
        }
    }
}
