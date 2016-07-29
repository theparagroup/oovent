using System;
using System.Collections.Generic;
using Oovent.Models;

namespace Oovent.Models.Ef
{
	public class EfEventType:EventType
	{
		public virtual List<EfEvent> Events { get; set;}
		public virtual List<EfEventTypeEntityTypeTag> EventTypeEntityTypeTags { get; set;}
	}
}
