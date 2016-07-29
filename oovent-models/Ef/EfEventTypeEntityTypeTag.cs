using System;
using System.Collections.Generic;
using Oovent.Models;

namespace Oovent.Models.Ef
{
	public class EfEventTypeEntityTypeTag:EventTypeEntityTypeTag
	{
		public virtual EfEntityType EntityType { get; set;}
		public virtual EfEventType EventType { get; set;}
		public virtual EfTag Tag { get; set;}
	}
}
