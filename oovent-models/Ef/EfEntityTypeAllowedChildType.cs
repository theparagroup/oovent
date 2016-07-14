using System;
using System.Collections.Generic;
using Oovent.Models;

namespace Oovent.Models.Ef
{
	public class EfEntityTypeAllowedChildType:EntityTypeAllowedChildType
	{
		public virtual EfEntityType ParentEntityType { get; set;}
		public virtual EfEntityType ChildEntityType { get; set;}
	}
}
