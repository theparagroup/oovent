using Oovent.Mvc.Models.Register;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Oovent.Models.Ef;

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
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [Route("register")]
        [HttpPost]
        public ActionResult Register(VmRegister vmRegister)
        {
            if (ModelState.IsValid)
            {
                using (var Db = new DbContext())
                {
                    EfEntityUserInfo eui = new EfEntityUserInfo();
                    eui.Email = vmRegister.Email;
                    eui.Password = vmRegister.Password;

                    Db.EntityUserInfo.Add(eui);
                    Db.SaveChanges();

                    return View();
                }
            }
            return View();
        }
    }
}