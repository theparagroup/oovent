using System;
using System.Web.Mvc;

namespace Oovent.Mvc
{
    public abstract class SiteController : Controller
    {
        public SiteController()
        {
            HtmlHelper.ClientValidationEnabled = false;
            HtmlHelper.UnobtrusiveJavaScriptEnabled = false;
        }
    }
}