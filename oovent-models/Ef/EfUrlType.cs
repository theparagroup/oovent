using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Oovent.Models;

namespace Oovent.Models.Ef
{
	public class EfUrlType:UrlType
	{
		[InverseProperty("UrlType")]
		public virtual List<EfUrl> Urls { get; set;}
	}
}
