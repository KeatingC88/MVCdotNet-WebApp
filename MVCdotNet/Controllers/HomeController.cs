using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCdotNet.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {            
            ViewBag.List = new List<string>()
            {
                "One",
                "Two",
                "Three",
                "Four",
                "Five"
            };

            return View();
        }

        public string GetAssemblyVersion()
        {
            return typeof(Controller).Assembly.GetName().Version.ToString();
        }
    }
}