using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Oovent.Models;

namespace Oovent.Models.Ef
{
	public class EfEntityEntityRelationshipType:EntityEntityRelationshipType
	{
		[InverseProperty("EntityEntityRelationshipType")]
		public virtual List<EfEntityEntityRelationship> EntityEntityRelationships { get; set;}
	}
}
