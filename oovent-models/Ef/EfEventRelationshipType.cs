using System;
using System.Collections.Generic;
using Oovent.Models;

namespace Oovent.Models.Ef
{
	public class EfEventRelationshipType:EventRelationshipType
	{
		public virtual List<EfEventEntityRelationship> EventEntityRelationships { get; set;}
	}
}
