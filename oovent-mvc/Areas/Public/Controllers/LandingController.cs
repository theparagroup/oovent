using System;
using System.Web.Mvc;
using Oovent.Mvc.Areas.Public.Models.Events;
using System.Web.Script.Serialization;
using Newtonsoft.Json;

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
        [HttpPost]
        public string LoadEvents()
        {
            return JsonConvert.SerializeObject(CrudEvents.GetFirstEvent());
        }

        [Route("~/Unauthorized")]
        public ActionResult Unauthorized()
        {
            return View();
        }
    }
}