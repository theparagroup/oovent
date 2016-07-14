using System;
using System.Collections.Generic;
using Oovent.Models;

namespace Oovent.Models.Ef
{
	public class EfEvent:Event
	{
		public virtual EfEventType EventType { get; set;}
		public virtual EfEvent ParentEvent { get; set;}
		public virtual List<EfEventEntityRelationship> EventEntityRelationships { get; set;}
		public virtual List<EfEvent> Events { get; set;}
	}
}
