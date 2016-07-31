using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Oovent.Models;

namespace Oovent.Models.Ef
{
	public class EfEntity:Entity
	{
		[ForeignKey("ParentEntityId")]
		public virtual EfEntity ParentEntity { get; set;}
		[ForeignKey("EntityTypeId")]
		public virtual EfEntityType EntityType { get; set;}
		[InverseProperty("ParentEntity")]
		public virtual List<EfEntity> Entities { get; set;}
		[InverseProperty("EntityA")]
		public virtual List<EfEntityEntityRelationship> EntityA_EntityEntityRelationships { get; set;}
		[InverseProperty("EntityB")]
		public virtual List<EfEntityEntityRelationship> EntityB_EntityEntityRelationships { get; set;}
		[InverseProperty("Entity")]
		public virtual List<EfEntityTag> EntityTags { get; set;}
		[InverseProperty("Entity")]
		public virtual List<EfEntityUrl> EntityUrls { get; set;}
		[InverseProperty("Entity")]
		public virtual List<EfEntityUserInfo> EntityUserInfo { get; set;}
		[InverseProperty("Entity")]
		public virtual List<EfEventEntityRelationship> EventEntityRelationships { get; set;}
	}
}
