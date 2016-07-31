using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Oovent.Models;

namespace Oovent.Models.Ef
{
	public class EfEntityUserInfo:EntityUserInfo
	{
		[ForeignKey("EntityId")]
		public virtual EfEntity Entity { get; set;}
	}
}
