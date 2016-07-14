using System;
using System.Collections.Generic;
using Oovent.Models;

namespace Oovent.Models.Ef
{
	public class EfUrl:Url
	{
		public virtual EfUrlType UrlType { get; set;}
		public virtual List<EfEntityUrl> EntityUrls { get; set;}
	}
}
