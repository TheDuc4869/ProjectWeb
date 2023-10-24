using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Watch()
        {
            return View();
        }
        public ActionResult Mac()
        {
            return View();
        }
        public ActionResult IPad()
        {
            return View();
        }
        public ActionResult IPhone()
        {
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}