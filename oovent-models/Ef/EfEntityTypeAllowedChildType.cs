using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Oovent.Models;

namespace Oovent.Models.Ef
{
	public class EfEntityTypeAllowedChildType:EntityTypeAllowedChildType
	{
		[ForeignKey("ChildEntityTypeId")]
		public virtual EfEntityType ChildEntityType { get; set;}
		[ForeignKey("ParentEntityTypeId")]
		public virtual EfEntityType ParentEntityType { get; set;}
	}
}
