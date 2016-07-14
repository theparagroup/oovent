using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using com.paralib.DataAnnotations;
using Oovent.Models.Metadata;


namespace Oovent.Models
{
	[MetadataType(typeof(EntityTypeAllowedChildTypeMetadata))]
	public partial class EntityTypeAllowedChildType
	{
	}
}

namespace Oovent.Models.Metadata
{
	public class EntityTypeAllowedChildTypeMetadata
	{

		[Key, Column(Order = 0)]
		[Display(Name="Id")]
		[Required(ErrorMessage="Id is required")]
		public object Id;

		[Display(Name="Parent Entity Type Id")]
		[Required(ErrorMessage="Parent Entity Type Id is required")]
		public object ParentEntityTypeId;

		[Display(Name="Child Entity Type Id")]
		[Required(ErrorMessage="Child Entity Type Id is required")]
		public object ChildEntityTypeId;
	}
}
