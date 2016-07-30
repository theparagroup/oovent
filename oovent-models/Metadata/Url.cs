using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using com.paralib.DataAnnotations;
using Oovent.Models.Metadata;


namespace Oovent.Models
{
	[MetadataType(typeof(UrlMetadata))]
	public partial class Url
	{
	}
}

namespace Oovent.Models.Metadata
{
	public class UrlMetadata
	{

		[Key, Column(Order = 0)]
		[Display(Name="Id")]
		[Required(ErrorMessage="Id is required")]
		public object Id;

		[Display(Name="Address")]
		[Required(ErrorMessage="Address is required")]
		[StringLength(2000)]
		public object Address;

		[Display(Name="Url Type Id")]
		[Required(ErrorMessage="Url Type Id is required")]
		public object UrlTypeId;
	}
}
