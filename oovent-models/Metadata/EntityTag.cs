using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using com.paralib.DataAnnotations;
using Oovent.Models.Metadata;


namespace Oovent.Models
{
	[MetadataType(typeof(EntityTagMetadata))]
	public partial class EntityTag
	{
	}
}

namespace Oovent.Models.Metadata
{
	public class EntityTagMetadata
	{

		[Key, Column(Order = 0)]
		[Display(Name="Id")]
		[Required(ErrorMessage="Id is required")]
		public object Id;

		[Display(Name="Entity Id")]
		[Required(ErrorMessage="Entity Id is required")]
		public object EntityId;

		[Display(Name="Tag Id")]
		[Required(ErrorMessage="Tag Id is required")]
		public object TagId;
	}
}
