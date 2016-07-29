using System;
using System.Collections;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using Oovent.Models;

namespace Oovent.Mvc.Intrastructure
{
    public static class ExtensionMethods
    {

        public static void RenderTable<T>(this HtmlHelper html, IEnumerable<T> source, Action<TableDefinition> init = null)
        {
            TableDefinition definition = null;


            //note: all this effort is to support anonymous types
            if (typeof(T) == typeof(object))
            {
                Type type = null;

                foreach (object obj in source)
                {
                    type = obj.GetType();
                }

                definition = new TableDefinition(source, type);

            }
            else
            {
                definition = new TableDefinition<T>(source);

            }


            if (init != null) init(definition);

            html.RenderPartial("~/Views/Table/Render.cshtml", definition);
        }

        public static EntityUserInfo GetUser(this HtmlHelper html)
        {
            return EntityUserInfo.GetUser(html.ViewContext.HttpContext.User.Identity.Name);
        }
    }
}