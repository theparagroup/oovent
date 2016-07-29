using System;

namespace Oovent.Models
{
	public partial class EventEntityRelationship
	{
		public int Id { get; set;}
		public int EventId { get; set;}
		public int EventEntityRelationshipTypeId { get; set;}
		public int EntityId { get; set;}
	}
}
