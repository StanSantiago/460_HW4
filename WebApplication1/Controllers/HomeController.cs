using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Converter()
        {
            ViewBag.Message = "";

            return View();
        }

        public ActionResult Color()
        {
            ViewBag.Message = "TODO: Make color mixer";

            return View();
        }
    }
}