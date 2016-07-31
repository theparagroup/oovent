using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Oovent.Models;

namespace Oovent.Models.Ef
{
	public class EfUrl:Url
	{
		[ForeignKey("UrlTypeId")]
		public virtual EfUrlType UrlType { get; set;}
		[InverseProperty("Url")]
		public virtual List<EfEntityUrl> EntityUrls { get; set;}
		[InverseProperty("Url")]
		public virtual List<EfEventUrl> EventUrls { get; set;}
	}
}
