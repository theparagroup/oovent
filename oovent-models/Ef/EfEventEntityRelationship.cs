using System;
using System.Collections.Generic;
using Oovent.Models;

namespace Oovent.Models.Ef
{
	public class EfEventEntityRelationship:EventEntityRelationship
	{
		public virtual EfEntity Entity { get; set;}
		public virtual EfEventRelationshipType EventRelationshipType { get; set;}
		public virtual EfEvent Event { get; set;}
	}
}
