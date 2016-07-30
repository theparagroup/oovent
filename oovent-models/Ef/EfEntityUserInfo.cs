using System;
using System.Collections.Generic;
using Oovent.Models;

namespace Oovent.Models.Ef
{
	public class EfEntityUserInfo:EntityUserInfo
	{
		public virtual EfEntity Id { get; set;}
	}
}
