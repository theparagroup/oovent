using System;
using System.Collections.Generic;
using Oovent.Models;

namespace Oovent.Models.Ef
{
	public class EfEntityUserInfoEntityRelationship:EntityUserInfoEntityRelationship
	{
		public virtual EfEntity Entity { get; set;}
		public virtual EfEntityUserInfo EntityUserInfo { get; set;}
	}
}
