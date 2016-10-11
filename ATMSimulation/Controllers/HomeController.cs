using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ATMSimulation.Controllers
{
    public class HomeController : Controller
    {
        // GET /home/index
        [MyLoggingFilter]
        public ActionResult Index()
        {
            return View();
        }

        // GET /home/about
        [ActionName("about-this-atm")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View("About");
        }

        public ActionResult Contact()
        {
            ViewBag.TheMessage = "Having trouble? Send us a message.";

            return View();
        }

        // [Authorize] Without paramaters allows any logged in user 
        // Ex. Parameter: [Authorize(Roles="administrator", Users="jsmith")]
        // Can also use at the controller level and use [AllowAnonymous]
        // for actions any user can commit

        [HttpPost]
        public ActionResult Contact(string message)
        {
            // TODO: Send message to intended recipients.
            ViewBag.TheMessage = "Thanks! We got your message.";

            return View();
        }

        public ActionResult Foo()
        {
            return View("About");
        }

        public ActionResult Serial(string letterCase)
        {
            var serial = "APSNETMVCATM1";
            if (letterCase == "lower")
            {
                return Content(serial.ToLower());
            }
            //return new HttpStatusCodeResult(403);
            
            //return Json(new { name = "serial", value = serial }, 
            //    JsonRequestBehavior.AllowGet);

            return RedirectToAction("Index");
        }
    }
}