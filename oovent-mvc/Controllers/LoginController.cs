using Oovent.Mvc.Models.Register;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Oovent.Mvc.Controllers
{
    public class LoginController : Controller
    {
        [Route("login")]
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [Route("login")]
        [HttpPost]
        public ActionResult Login(VmRegister vmRegister)
        {
            return View();
        }

        [Route("register")]
        public ActionResult Register()
        {
            return View();
        }
    }
}