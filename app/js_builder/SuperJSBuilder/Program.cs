using SuperJSBuilder.gen.dir_app;
using SuperJSBuilder.gen.dir_walle2;
using SuperJSBuilder.gen.less_app;
using SuperJSBuilder.gen.less_walle2;
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
            ConfigService.init();

            //2.wall2
            //2.1.gen
            DirServiceWalle2.gen(ConfigService.getValue4WallE(ConfigService.KEY_SRC_DIR_PATH));
            LessServiceWalle2.gen(ConfigService.getValue4WallE(ConfigService.KEY_SRC_DIR_PATH));
            //2.2.merge
            MergeServiceWalle2.merge();

            //3.app
            //3.1.gen
            DirServiceApp.gen(ConfigService.getValue4App(ConfigService.KEY_SRC_DIR_PATH));
            LessServiceApp.gen(ConfigService.getValue4App(ConfigService.KEY_SRC_DIR_PATH));

            Console.ReadLine();
        }
    }
}
