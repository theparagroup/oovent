using System;

namespace Oovent.Models
{
	public partial class EntityTypeAllowedChildType
	{
		public int Id { get; set;}
		public int ParentEntityTypeId { get; set;}
		public int ChildEntityTypeId { get; set;}
	}
}
