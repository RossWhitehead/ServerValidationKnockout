using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Practices.EnterpriseLibrary.Logging;

namespace ServerValidationKnockout.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Logger.SetLogWriter(new LogWriterFactory().Create());

            Logger.Write(new LogEntry(
                message: "logging message",
                category: "category 1",
                priority: 1,
                eventId: 123,
                severity: System.Diagnostics.TraceEventType.Error,
                title: "logging title",
                properties: null
                ));


            //throw new Exception("Exception in index");

            return View();
        }

        public ActionResult CreateProduct()
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