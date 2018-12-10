using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using KortKiralamaOdevi.Controllers;

namespace KortKiralamaOdevi.Areas.admin.Controllers
{
    [Authorize(Roles = "Admin")]
    public class DashboradController : BaseController
    {
        // GET: admin/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}