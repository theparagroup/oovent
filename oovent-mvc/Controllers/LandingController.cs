using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Oovent.Mvc.Controllers
{
    public class LandingController : SiteController
    {
        public ActionResult Index()
        {
            return View();
        }

        [Route("unauthorized")]
        public ActionResult Ununauthorized()
        {
            return View();
        }
    }
}