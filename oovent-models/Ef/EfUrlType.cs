using System;
using System.Collections.Generic;
using Oovent.Models;

namespace Oovent.Models.Ef
{
	public class EfUrlType:UrlType
	{
		public virtual List<EfUrl> Urls { get; set;}
	}
}
