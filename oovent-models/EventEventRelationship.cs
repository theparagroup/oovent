using System;

namespace Oovent.Models
{
	public partial class EventEventRelationship
	{
		public int Id { get; set;}
		public int EventAId { get; set;}
		public int EventEventRelationshipTypeId { get; set;}
		public int EventBId { get; set;}
	}
}
