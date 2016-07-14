using System;
using System.Collections.Generic;
using Oovent.Models;

namespace Oovent.Models.Ef
{
	public class EfEntityUserInfo:EntityUserInfo
	{
		public virtual List<EfEntityUserInfoEntityRelationship> EntityUserInfoEntityRelationships { get; set;}
	}
}
