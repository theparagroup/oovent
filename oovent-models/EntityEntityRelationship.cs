using System;

namespace Oovent.Models
{
	public partial class EntityEntityRelationship
	{
		public int Id { get; set;}
		public int EntityIdA { get; set;}
		public int EntityEntityRelationshipTypeId { get; set;}
		public int EntityIdB { get; set;}
	}
}
