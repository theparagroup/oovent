using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using com.paralib.DataAnnotations;
using Oovent.Models.Metadata;


namespace Oovent.Models
{
	[MetadataType(typeof(EntityUrlMetadata))]
	public partial class EntityUrl
	{
	}
}

namespace Oovent.Models.Metadata
{
	public class EntityUrlMetadata
	{

		[Key, Column(Order = 0)]
		[Display(Name="Id")]
		[Required(ErrorMessage="Id is required")]
		public object Id;

		[Display(Name="Entity Id")]
		[Required(ErrorMessage="Entity Id is required")]
		public object EntityId;

		[Display(Name="Url Id")]
		[Required(ErrorMessage="Url Id is required")]
		public object UrlId;
	}
}
