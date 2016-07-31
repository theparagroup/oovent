using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Oovent.Models;

namespace Oovent.Models.Ef
{
	public class EfEventType:EventType
	{
		[InverseProperty("EventType")]
		public virtual List<EfEventTypeEntityTypeTag> EventTypeEntityTypeTags { get; set;}
		[InverseProperty("EventType")]
		public virtual List<EfEvent> Events { get; set;}
	}
}
