using System;
using System.Collections.Generic;
using Oovent.Models;

namespace Oovent.Models.Ef
{
	public class EfEntityEntityRelationshipType:EntityEntityRelationshipType
	{
		public virtual List<EfEntityEntityRelationship> EntityEntityRelationships { get; set;}
	}
}
