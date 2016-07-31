using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Oovent.Models;

namespace Oovent.Models.Ef
{
	public class EfEventEntityRelationship:EventEntityRelationship
	{
		[ForeignKey("EntityId")]
		public virtual EfEntity Entity { get; set;}
		[ForeignKey("EventEntityRelationshipTypeId")]
		public virtual EfEventEntityRelationshipType EventEntityRelationshipType { get; set;}
		[ForeignKey("EventId")]
		public virtual EfEvent Event { get; set;}
	}
}
