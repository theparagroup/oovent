using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Oovent.Models;

namespace Oovent.Models.Ef
{
	public class EfEntityEntityRelationship:EntityEntityRelationship
	{
		[ForeignKey("EntityAId")]
		public virtual EfEntity EntityA { get; set;}
		[ForeignKey("EntityBId")]
		public virtual EfEntity EntityB { get; set;}
		[ForeignKey("EntityEntityRelationshipTypeId")]
		public virtual EfEntityEntityRelationshipType EntityEntityRelationshipType { get; set;}
	}
}
