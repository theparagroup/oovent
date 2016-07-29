using System;

namespace Oovent.Models
{
	public partial class Tag
	{
		public int Id { get; set;}
		public int? ParentTagId { get; set;}
		public string Name { get; set;}
		public int Ordinal { get; set;}
	}
}
