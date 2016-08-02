using System;
using System.Web.Mvc;


namespace Oovent.Mvc.Areas.Public
{
    [RouteArea("public")]
    [AllowAnonymous]
    public class PublicController : SiteController
    {
    }
}