using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Oovent.Models;

namespace Oovent.Models.Ef
{
	public class EfEvent:Event
	{
		[ForeignKey("EventTypeId")]
		public virtual EfEventType EventType { get; set;}
		[ForeignKey("ParentEventId")]
		public virtual EfEvent ParentEvent { get; set;}
		[InverseProperty("Event")]
		public virtual List<EfEventEntityRelationship> EventEntityRelationships { get; set;}
		[InverseProperty("EventA")]
		public virtual List<EfEventEventRelationship> EventA_EventEventRelationships { get; set;}
		[InverseProperty("EventB")]
		public virtual List<EfEventEventRelationship> EventB_EventEventRelationships { get; set;}
		[InverseProperty("Event")]
		public virtual List<EfEventUrl> EventUrls { get; set;}
		[InverseProperty("ParentEvent")]
		public virtual List<EfEvent> Events { get; set;}
	}
}
