using System;
using System.Collections.Generic;
using Oovent.Models;

namespace Oovent.Models.Ef
{
	public class EfEntityEntityRelationship:EntityEntityRelationship
	{
		public virtual EfEntity EntityIdA { get; set;}
		public virtual EfEntity EntityIdB { get; set;}
		public virtual EfEntityEntityRelationshipType EntityEntityRelationshipType { get; set;}
	}
}
