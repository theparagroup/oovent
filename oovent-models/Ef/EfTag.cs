using System;
using System.Collections.Generic;
using Oovent.Models;

namespace Oovent.Models.Ef
{
	public class EfTag:Tag
	{
		public virtual EfTag ParentTag { get; set;}
		public virtual List<EfTag> Tags { get; set;}
		public virtual List<EfEventTypeEntityTypeTag> EventTypeEntityTypeTags { get; set;}
		public virtual List<EfEntityTag> EntityTags { get; set;}
	}
}
