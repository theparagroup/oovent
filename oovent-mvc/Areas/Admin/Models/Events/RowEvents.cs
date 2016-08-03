using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Oovent.Mvc.Areas.Admin.Models.Events
{    
    public class RowEvents
    {
        [Column(Raw = true)]
        public string Client { get; set; }
        public string JobDescription { get; set; }
        public string JobStatus { get; set; }
        public DateTime VisitOn { get; set; }
        public DateTime? PerformOn { get; set; }
        public string Estimator { get; set; }
        public string Foreman { get; set; }
        public string Craftsman { get; set; }
    }
}