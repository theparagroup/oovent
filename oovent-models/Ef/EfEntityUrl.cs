using System;
using System.Collections.Generic;
using Oovent.Models;

namespace Oovent.Models.Ef
{
	public class EfEntityUrl:EntityUrl
	{
		public virtual EfEntity Entity { get; set;}
		public virtual EfUrl Url { get; set;}
	}
}
