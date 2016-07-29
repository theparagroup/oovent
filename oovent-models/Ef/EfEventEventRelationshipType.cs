using System;
using System.Collections.Generic;
using Oovent.Models;

namespace Oovent.Models.Ef
{
	public class EfEventEventRelationshipType:EventEventRelationshipType
	{
		public virtual List<EfEventEventRelationship> EventEventRelationships { get; set;}
	}
}
