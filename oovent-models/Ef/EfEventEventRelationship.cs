using System;
using System.Collections.Generic;
using Oovent.Models;

namespace Oovent.Models.Ef
{
	public class EfEventEventRelationship:EventEventRelationship
	{
		public virtual EfEventEventRelationshipType EventEventRelationshipType { get; set;}
		public virtual EfEvent EventIdB { get; set;}
		public virtual EfEvent EventIdA { get; set;}
	}
}
