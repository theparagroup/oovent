using System;
using System.Web.Mvc;
using com.paralib.Mvc.Authorization;

namespace Oovent.Mvc.Areas.Admin
{
    [RouteArea("admin")]
    [Permissions(UnauthenticatedUrl = "~/login", UnauthorizedUrl = "~/unauthorized", Roles = "admin")]
    public class AdminController : SiteController
    {
    }
}