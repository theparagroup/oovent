using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Oovent.Mvc.Areas.Admin.Controllers
{
    [Route("~/admin/{action}")]
    public class LandingController : AdminController
    {
        public ActionResult Dashboard()
        {
            return View();
        }
    }
}