using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Oovent.Models;

namespace Oovent.Models.Ef
{
	public class EfEventEventRelationship:EventEventRelationship
	{
		[ForeignKey("EventEventRelationshipTypeId")]
		public virtual EfEventEventRelationshipType EventEventRelationshipType { get; set;}
		[ForeignKey("EventAId")]
		public virtual EfEvent EventA { get; set;}
		[ForeignKey("EventBId")]
		public virtual EfEvent EventB { get; set;}
	}
}
