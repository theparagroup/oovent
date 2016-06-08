using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Oovent.Models;

namespace Oovent.Mvc.Controllers
{
    public class DummyEventController : Controller
    {
        // GET: DummyEvent
        public ActionResult Index()
        {
            return View();
        }

        [Route("DummyEvent")]
        public ActionResult DummyEvent()
        {
            DummyEvent de = new DummyEvent();
            de.Id = 0;
            de.Name = "Pumpkins At the Spider Party";
            de.Content = "Please come take our pumpkins they are full of spiders and we don't want them anymore.";

            ViewBag.EventName = de.Name;
            ViewBag.Content = de.Content;

            return View();
        }
    }
}