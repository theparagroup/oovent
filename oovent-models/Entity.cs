using System;

namespace Oovent.Models
{
	public partial class Entity
	{
		public int Id { get; set;}
		public int ParentEntityId { get; set;}
		public int EntityTypeId { get; set;}
		public string Name { get; set;}
	}
}
