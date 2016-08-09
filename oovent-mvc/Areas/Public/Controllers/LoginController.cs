using System;
using System.Linq;
using System.Web.Mvc;
using System.Collections.Generic;
using Oovent.Models;
using Oovent.Models.Ef;
using com.paralib.Utils;
using com.paralib.Mvc.Authorization;
using Oovent.Mvc.Areas.Public.Models;
using com.paralib.Mvc.Authentication;

namespace Oovent.Mvc.Areas.Public.Controllers
{
    public class LoginController : PublicController
    {
        [Route("~/login")]
        [HttpGet]
        public ActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
            {
                return Redirect("~/index");
            }
            else
            {
                return View();
            }
        }

        [Route("~/login")]
        [HttpPost]
        public ActionResult Login(VmLogin vmLogin)
        {
            if (ModelState.IsValid)
            {
                var user = EntityUserInfo.GetUser(vmLogin.Email);
                List<string> roles = new List<string>();

                if (user == null)
                {
                    ModelState.AddModelError("", "That email was not found on our records.");
                }
                else
                {
                    if (Crypto.VerifyPassword(user.Password, vmLogin.Password))
                    {
                        using (DbContext db = new DbContext())
                        {
                            var query = from e in db.Entities
                                        where e.Id == user.EntityId && e.EntityTypeId == 2
                                        select e;

                            if (query.Count() > 0)
                            {
                                roles.Add("admin");
                            }
                        }

                        ParaPrinciple paraPrinciple = new ParaPrinciple(user.Email, roles.ToArray());
                        Forms.Authenticate(paraPrinciple);
                        return Redirect("~/admin/dashboard");
                    }
                    else
                    {
                        ModelState.AddModelError("", "That password was incorrect.");
                    }
                }
            }
            return View(vmLogin);
        }
    }
}