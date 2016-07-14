using System;
using System.Collections.Generic;
using Oovent.Models;

namespace Oovent.Models.Ef
{
	public class EfEntityTag:EntityTag
	{
		public virtual EfEntity Entity { get; set;}
		public virtual EfTag Tag { get; set;}
	}
}
