using System;
using System.Collections.Generic;
using Oovent.Models;

namespace Oovent.Models.Ef
{
	public class EfEventEntityRelationshipType:EventEntityRelationshipType
	{
		public virtual List<EfEventEntityRelationship> EventEntityRelationships { get; set;}
	}
}
