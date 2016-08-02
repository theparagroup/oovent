using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Oovent.Mvc.Areas.Public.Models;
using Oovent.Mvc.Areas.Public;
using com.paralib.Utils;
using Oovent.Models.Ef;
using com.paralib.Mvc.Authorization;
using com.paralib.Mvc.Authentication;
using Oovent.Models;

namespace Oovent.Mvc.Areas.Public.Controllers
{
    [Route("~/{action}")]
    public class LandingController : PublicController
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Unauthorized()
        {
            return View();
        }

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