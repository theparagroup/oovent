using System;

namespace Oovent.Models
{
	public partial class Event
	{
		public int Id { get; set;}
		public int ParentEventId { get; set;}
		public int EventTypeId { get; set;}
		public int Description { get; set;}
		public DateTime Start { get; set;}
		public DateTime End { get; set;}
		public int Ordinal { get; set;}
		public bool M { get; set;}
		public bool T { get; set;}
		public bool W { get; set;}
		public bool Th { get; set;}
		public bool F { get; set;}
		public bool S { get; set;}
		public bool Su { get; set;}
	}
}
