using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KortKiralamaOdevi.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            var user = GetLoginedUser();

            return View();
        }
       
        public ActionResult Contact()
        {
            var user = GetLoginedUser();

            return Json(user,JsonRequestBehavior.AllowGet);
        }
    }
}