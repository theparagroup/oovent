using System;

namespace Oovent.Models
{
	public partial class EntityEntityRelationship
	{
		public int Id { get; set;}
		public int EntityAId { get; set;}
		public int EntityEntityRelationshipTypeId { get; set;}
		public int EntityBId { get; set;}
	}
}
