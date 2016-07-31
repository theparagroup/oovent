using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Oovent.Models;

namespace Oovent.Models.Ef
{
	public class EfEntityType:EntityType
	{
		[ForeignKey("ParentEntityTypeId")]
		public virtual EfEntityType ParentEntityType { get; set;}
		[InverseProperty("EntityType")]
		public virtual List<EfEntity> Entities { get; set;}
		[InverseProperty("ChildEntityType")]
		public virtual List<EfEntityTypeAllowedChildType> ChildEntityType_EntityTypeAllowedChildTypes { get; set;}
		[InverseProperty("ParentEntityType")]
		public virtual List<EfEntityTypeAllowedChildType> ParentEntityType_EntityTypeAllowedChildTypes { get; set;}
		[InverseProperty("ParentEntityType")]
		public virtual List<EfEntityType> EntityTypes { get; set;}
		[InverseProperty("EntityType")]
		public virtual List<EfEventTypeEntityTypeTag> EventTypeEntityTypeTags { get; set;}
	}
}
