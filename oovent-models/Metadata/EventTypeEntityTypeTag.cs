using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using com.paralib.DataAnnotations;
using Oovent.Models.Metadata;


namespace Oovent.Models
{
	[MetadataType(typeof(EventTypeEntityTypeTagMetadata))]
	public partial class EventTypeEntityTypeTag
	{
	}
}

namespace Oovent.Models.Metadata
{
	public class EventTypeEntityTypeTagMetadata
	{

		[Key, Column(Order = 0)]
		[Display(Name="Id")]
		[Required(ErrorMessage="Id is required")]
		public object Id;

		[Display(Name="Event Type Id")]
		[Required(ErrorMessage="Event Type Id is required")]
		public object EventTypeId;

		[Display(Name="Entity Type Id")]
		[Required(ErrorMessage="Entity Type Id is required")]
		public object EntityTypeId;

		[Display(Name="Tag Id")]
		[Required(ErrorMessage="Tag Id is required")]
		public object TagId;
	}
}
