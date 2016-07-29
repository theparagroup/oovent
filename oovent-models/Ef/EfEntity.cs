using System;
using System.Collections.Generic;
using Oovent.Models;

namespace Oovent.Models.Ef
{
	public class EfEntity:Entity
	{
		public virtual EfEntity ParentEntity { get; set;}
		public virtual EfEntityType EntityType { get; set;}
		public virtual List<EfEntity> Entities { get; set;}
		public virtual List<EfEntityEntityRelationship> EntityEntityRelationships { get; set;}
		public virtual List<EfEntityTag> EntityTags { get; set;}
		public virtual List<EfEntityUserInfo> EntityUserInfo { get; set;}
		public virtual List<EfEventEntityRelationship> EventEntityRelationships { get; set;}
		public virtual List<EfEntityUrl> EntityUrls { get; set;}
	}
}
