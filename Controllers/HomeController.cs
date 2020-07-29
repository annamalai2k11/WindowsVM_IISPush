using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WindowsVM_IISPush.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            System.Diagnostics.Trace.TraceInformation("Invoking Home controller");
            return View();
        }

        public ActionResult About()
        {
            System.Diagnostics.Trace.TraceInformation("Invoking About Method");
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            System.Diagnostics.Trace.TraceInformation("Invoking Contact Method");
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}