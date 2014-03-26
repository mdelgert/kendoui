using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Base.MvcApplication.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            //ViewBag.Message = "Kendo UI MVC demo application.";
            return View();
        }
        public ActionResult Sitemap()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }

        public ActionResult Links()
        {
            return View();
        }

        public ActionResult Bootstrap()
        {
            return View();
        }

    }

}
