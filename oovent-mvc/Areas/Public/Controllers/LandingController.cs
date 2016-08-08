using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Oovent.Mvc.Areas.Public.Controllers
{
    public class LandingController : PublicController
    {
        [Route("~/Index")]
        // GET: Public/Landing
        public ActionResult Index()
        {
            return View();
        }

        [Route("~/Unauthorized")]
        // GET: Public/Landing
        public ActionResult Unauthorized()
        {
            return View();
        }
    }
}