using System;

namespace Oovent.Models
{
	public partial class EventTypeEntityTypeTag
	{
		public int Id { get; set;}
		public int EventTypeId { get; set;}
		public int EntityTypeId { get; set;}
		public int TagId { get; set;}
	}
}
