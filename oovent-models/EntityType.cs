using System;

namespace Oovent.Models
{
	public partial class EntityType
	{
		public int Id { get; set;}
		public int? ParentEntityTypeId { get; set;}
		public string Name { get; set;}
		public int? TopLevelTagId { get; set;}
	}
}
