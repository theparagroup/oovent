using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Oovent.Models;

namespace Oovent.Models.Ef
{
	public class EfEventEntityRelationshipType:EventEntityRelationshipType
	{
		[InverseProperty("EventEntityRelationshipType")]
		public virtual List<EfEventEntityRelationship> EventEntityRelationships { get; set;}
	}
}
