using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oovent.Models;

namespace oovent_webapi.Api.V1.Admin
{
    public class Event
    {
        public int Id { get; set; }
        public Oovent.Models.Event ParentEvent { get; set; }
        public EventType EventType { get; set; } 
        public string Title { get; set; }
        public string Description { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Price { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public int Ordinal { get; set; }
        public bool M { get; set; }
        public bool T { get; set; }
        public bool W { get; set; }
        public bool Th { get; set; }
        public bool F { get; set; }
        public bool S { get; set; }
        public bool Su { get; set; }
    }
}
