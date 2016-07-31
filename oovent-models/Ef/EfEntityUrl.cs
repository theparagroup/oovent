using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Oovent.Models;

namespace Oovent.Models.Ef
{
	public class EfEntityUrl:EntityUrl
	{
		[ForeignKey("EntityId")]
		public virtual EfEntity Entity { get; set;}
		[ForeignKey("UrlId")]
		public virtual EfUrl Url { get; set;}
	}
}
