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

            double final = 0;

            string metric = Request.QueryString["Metric"];
            double miles = Convert.ToDouble(Request.QueryString["Miles"]);

            final = miles * 1.60934;

            if (metric == "millimeters")
                final *= 1000000;
            else if (metric == "centimeters")
                final *= 100000;
            else if (metric == "meters")
                final *= 1000;
            else if (metric == "kilometers")
            { }
            else if((metric == "")&&(miles == 0))
            {
                ViewBag.Message = "";
                return View();
            }
            else
            {
                ViewBag.Message = "Please input valid values";
                return View();
            }

            ViewBag.Message = miles + " miles is " + final + " " + metric;

            return View();
        }

        public ActionResult Color()
        {
            ViewBag.Message = "TODO: Make color mixer";

            return View();
        }
    }
}
