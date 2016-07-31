using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Oovent.Models;

namespace Oovent.Models.Ef
{
	public class EfEventTypeEntityTypeTag:EventTypeEntityTypeTag
	{
		[ForeignKey("EntityTypeId")]
		public virtual EfEntityType EntityType { get; set;}
		[ForeignKey("EventTypeId")]
		public virtual EfEventType EventType { get; set;}
		[ForeignKey("TagId")]
		public virtual EfTag Tag { get; set;}
	}
}
