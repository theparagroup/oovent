using System;
using System.Collections.Generic;
using Oovent.Models;

namespace Oovent.Models.Ef
{
	public class EfEntityType:EntityType
	{
		public virtual List<EfEntityTypeAllowedChildType> EntityTypeAllowedChildTypes { get; set;}
		public virtual List<EfEntity> Entities { get; set;}
	}
}
