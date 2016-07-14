using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using com.paralib.DataAnnotations;
using Oovent.Models.Metadata;


namespace Oovent.Models
{
	[MetadataType(typeof(EntityTypeMetadata))]
	public partial class EntityType
	{
	}
}

namespace Oovent.Models.Metadata
{
	public class EntityTypeMetadata
	{

		[Key, Column(Order = 0)]
		[Display(Name="Id")]
		[Required(ErrorMessage="Id is required")]
		public object Id;

		[Display(Name="Name")]
		[Required(ErrorMessage="Name is required")]
		[StringLength(64)]
		public object Name;

		[Display(Name="Top Level Tag Id")]
		public object TopLevelTagId;
	}
}
