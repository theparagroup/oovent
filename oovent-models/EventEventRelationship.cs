using System;

namespace Oovent.Models
{
	public partial class EventEventRelationship
	{
		public int Id { get; set;}
		public int EventIdA { get; set;}
		public int EventEventRelationshipTypeId { get; set;}
		public int EventIdB { get; set;}
	}
}
