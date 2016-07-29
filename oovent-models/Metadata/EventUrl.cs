using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using com.paralib.DataAnnotations;
using Oovent.Models.Metadata;


namespace Oovent.Models
{
	[MetadataType(typeof(EventUrlMetadata))]
	public partial class EventUrl
	{
	}
}

namespace Oovent.Models.Metadata
{
	public class EventUrlMetadata
	{

		[Key, Column(Order = 0)]
		[Display(Name="Id")]
		[Required(ErrorMessage="Id is required")]
		public object Id;

		[Display(Name="Event Id")]
		[Required(ErrorMessage="Event Id is required")]
		public object EventId;

		[Display(Name="Url Id")]
		[Required(ErrorMessage="Url Id is required")]
		public object UrlId;
	}
}
