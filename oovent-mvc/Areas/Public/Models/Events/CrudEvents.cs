using System;
using System.Collections.Generic;
using System.Linq;
using Oovent.Models;
using Oovent.Models.Ef;

namespace Oovent.Mvc.Areas.Public.Models.Events
{
    public class CrudEvents
    {
        public static List<EfEvent> GetEvents()
        {
            using (DbContext db = new DbContext())
            {
                var query = from e in db.Events
                            select e;

                return query.ToList();
            }
        }

        public static EfEvent GetFirstEvent()
        {
            using (DbContext db = new DbContext())
            {
                var query = from e in db.Events
                            select e;

                return query.FirstOrDefault();
            }
        }

        public static List<string> GetEventNames()
        {
            using (DbContext db = new DbContext())
            {
                var query = from e in db.Events
                            select e.Title;

                return query.ToList();
            }
        }
    }
}