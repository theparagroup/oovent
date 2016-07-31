using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Oovent.Models;

namespace Oovent.Models.Ef
{
	public class EfTag:Tag
	{
		[ForeignKey("ParentTagId")]
		public virtual EfTag ParentTag { get; set;}
		[InverseProperty("Tag")]
		public virtual List<EfEntityTag> EntityTags { get; set;}
		[InverseProperty("Tag")]
		public virtual List<EfEventTypeEntityTypeTag> EventTypeEntityTypeTags { get; set;}
		[InverseProperty("ParentTag")]
		public virtual List<EfTag> Tags { get; set;}
	}
}
