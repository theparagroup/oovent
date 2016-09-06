using System;
using System.Linq;
using System.Web.Mvc;
using Oovent.Mvc.Areas.Public.Models.Events;
using System.Web.Script.Serialization;
using Utils = com.paralib.Utils;
using Oovent.Models.Ef;
using System.Threading.Tasks;

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

        [HttpGet]
        public ActionResult GetEvents(string eventId)
        {
            return PartialView("IndexPartial");
        }

        [Route("~/LoadEvents")]
        [HttpGet]
        public JsonResult LoadEvents()
        {
            using (DbContext db = new DbContext())
            {
                var query = from e in db.Events
                            select new { Id = e.Id, Title = e.Title, EventTypeId = e.EventTypeId, StartDate = e.Start, EndDate = e.End };

                return Json(query.ToList(), JsonRequestBehavior.AllowGet);
            }            
        }

        [Route("~/Unauthorized")]
        public ActionResult Unauthorized()
        {
            return View();
        }
    }
}