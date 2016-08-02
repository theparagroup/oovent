using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Oovent.Mvc.Areas.Public.Controllers
{
    public class LandingController : Controller
    {
        // GET: Public/Landing
        public ActionResult Index()
        {
            return View();
        }
    }
}