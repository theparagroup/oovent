using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Oovent.Mvc.Areas.Public.Models.Events;

namespace Oovent.Mvc.Areas.Public.Controllers
{
    public class LandingController : PublicController
    {
        [Route("~/Index")]
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [Route("~/LoadEvents")]
        public string LoadEvents()
        {
            return "Test";
        }

        [Route("~/Unauthorized")]
        public ActionResult Unauthorized()
        {
            return View();
        }
    }
}