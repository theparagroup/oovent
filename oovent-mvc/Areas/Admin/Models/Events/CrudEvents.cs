using com.paralib.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Oovent.Models;
using Oovent.Models.Ef;

namespace Oovent.Mvc.Areas.Admin.Models.Events
{
    public class CrudEvents
    {
        public static List<string> Name(string email)
        {
            var user = EntityUserInfo.GetUser(email);
            using (DbContext db = new DbContext())
            {
                var query = from e in db.Events
                            from eer in db.EventEntityRelationships
                            where eer.EntityId == user.EntityId && eer.EventId == e.Id
                            select e.Title;

                return query.ToList();
            }
        }
    }
}