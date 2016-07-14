using System;
using System.Collections.Generic;
using Oovent.Models;

namespace Oovent.Models.Ef
{
	public class EfTag:Tag
	{
		public virtual List<EfEntityTag> EntityTags { get; set;}
	}
}
