﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Oovent.Mvc.Areas.Admin.Controllers
{
    [Route("~/admin/myevents/{action}")]
    public class EventController : AdminController
    {
        public ActionResult List()
        {
            return View();
        }

        public ActionResult Add()
        {
            return View();
        }
    }
}