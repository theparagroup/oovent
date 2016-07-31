using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Oovent.Models;

namespace Oovent.Models.Ef
{
	public class EfEventEventRelationshipType:EventEventRelationshipType
	{
		[InverseProperty("EventEventRelationshipType")]
		public virtual List<EfEventEventRelationship> EventEventRelationships { get; set;}
	}
}
