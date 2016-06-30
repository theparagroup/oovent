using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Oovent.Mvc.Controllers
{
    public class MainController : Controller
    {
        [Route("login")]
        public ActionResult Login()
        {
            return View();
        }

        [Route("enter-event")]
        public ActionResult EnterEvent()
        {
            return View();
        }
    }
}