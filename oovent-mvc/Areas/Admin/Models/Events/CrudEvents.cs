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
        [ParaType(ParaTypes.Key)]
        public int Id { get; set; }

        [Required(ErrorMessage = "*")]
        [ParaType(ParaTypes.Name)]
        public string Title { get; set; }

        [ParaType(ParaTypes.Currency)]
        public string Price { get; set; }

        [ParaType(ParaTypes.Key)]
        public Entity What { get; set; }

        [ParaType(ParaTypes.Key)]
        public Entity Where { get; set; }

        [ParaType(ParaTypes.DateTime)]
        public DateTime StartDate { get; set; }

        [ParaType(ParaTypes.DateTime)]
        public DateTime EndDate { get; set; }

        [ParaType(ParaTypes.Description)]
        public string Description { get; set; }

        [ParaType(ParaTypes.Key)]
        public Event ParentEvent { get; set; }

        [ParaType(ParaTypes.Phone)]
        public string Phone { get; set; }

        [ParaType(ParaTypes.Email)]
        public string Email { get; set; }

        public static List<EfEvent> GetUserEvents(string email)
        {
            var user = EntityUserInfo.GetUser(email);
            using (DbContext db = new DbContext())
            {
                var query = from e in db.Events
                            from eer in db.EventEntityRelationships
                            where eer.EntityId == user.EntityId && eer.EventId == e.Id
                            select e;

                return query.ToList();
            }
        }
    }
}