using System;
using System.Linq;
using System.Web.Mvc;
using Oovent.Mvc.Areas.Public.Models.Events;
using System.Web.Script.Serialization;
using Utils = com.paralib.Utils;
using Oovent.Models.Ef;

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
        public JsonResult LoadEvents()
        {
            using (DbContext db = new DbContext())
            {
                var query = from e in db.Events
                            select new { Id = e.Id };

                return Json(query.ToList());
            }            
        }

        [Route("~/Unauthorized")]
        public ActionResult Unauthorized()
        {
            return View();
        }
    }
}