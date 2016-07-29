using System;
using System.Collections.Generic;
using Oovent.Models;

namespace Oovent.Models.Ef
{
	public class EfEventUrl:EventUrl
	{
		public virtual EfEvent Event { get; set;}
		public virtual EfUrl Url { get; set;}
	}
}
