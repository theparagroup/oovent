using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Oovent.Models;

namespace Oovent.Models.Ef
{
	public class EfEventUrl:EventUrl
	{
		[ForeignKey("EventId")]
		public virtual EfEvent Event { get; set;}
		[ForeignKey("UrlId")]
		public virtual EfUrl Url { get; set;}
	}
}
