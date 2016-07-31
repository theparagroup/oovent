using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Oovent.Models;

namespace Oovent.Models.Ef
{
	public class EfEntityTag:EntityTag
	{
		[ForeignKey("EntityId")]
		public virtual EfEntity Entity { get; set;}
		[ForeignKey("TagId")]
		public virtual EfTag Tag { get; set;}
	}
}
