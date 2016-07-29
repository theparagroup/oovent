using System;
using System.Linq;
using System.Web.Mvc;
using com.paralib.Utils;
using com.paralib.Mvc.Authentication;
using com.paralib.Mvc.Authorization;
using Oovent.Models.Ef;
using Oovent.Mvc.Models.Login;
using Oovent.Mvc.Models.Register;
using System.Collections.Generic;

namespace Oovent.Mvc.Controllers
{
    public class LoginController : Controller
    {
        [Route("login")]
        [HttpGet]
        public ActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
            {
                return Redirect("~/");
            }
            else
            {
                return View();
            }
        }

        [Route("login")]
        [HttpPost]
        public ActionResult Login(VmLogin vmLogin)
        {
            if (ModelState.IsValid)
            {
                var user = Oovent.Models.EntityUserInfo.GetUser(vmLogin.Email);
                List<string> roles = new List<string>();

                if (user == null)
                {
                    ModelState.AddModelError("", "");
                }
                else
                {
                    if (Crypto.VerifyPassword(user.Password, vmLogin.Password))
                    {
                        using (DbContext db = new DbContext())
                        {
                            var query = from e in db.Entities
                                        where e.Id == user.Id  && e.EntityTypeId == 2                                   
                                        select e;
                            
                            if (query.Count() > 0)
                            {
                                roles.Add("admin");
                            }                            
                        }

                        ParaPrinciple paraPrinciple = new ParaPrinciple(user.Email, roles.ToArray());
                        Forms.Authenticate(paraPrinciple);
                    }
                }
            }
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