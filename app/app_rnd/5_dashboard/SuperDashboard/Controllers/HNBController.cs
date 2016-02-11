using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuperDashboard.Controllers
{
    public class HNBController : Controller
    {
        #region Index

        public ActionResult Index()
        {
            return View();
        }

        #endregion

        #region _1_build_deploy

        public ActionResult _1_build_deploy()
        {
            ViewBag.Message = "啦啦啦";

            return View();
        }

        #endregion

        #region _2_smk

        public ActionResult _2_smk()
        {
            ViewBag.Message = "啦啦啦";

            return View();
        }

        #endregion

        #region _3_ys

        public ActionResult _3_ys()
        {
            ViewBag.Message = "啦啦啦";

            return View();
        }

        #endregion
    }
}