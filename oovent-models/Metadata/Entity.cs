using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using com.paralib.DataAnnotations;
using Oovent.Models.Metadata;


namespace Oovent.Models
{
	[MetadataType(typeof(EntityMetadata))]
	public partial class Entity
	{
	}
}

namespace Oovent.Models.Metadata
{
	public class EntityMetadata
	{

		[Key, Column(Order = 0)]
		[Display(Name="Id")]
		[Required(ErrorMessage="Id is required")]
		public object Id;

		[Display(Name="Parent Entity Id")]
		public object ParentEntityId;

		[Display(Name="Entity Type Id")]
		[Required(ErrorMessage="Entity Type Id is required")]
		public object EntityTypeId;

		[Display(Name="Name")]
		[Required(ErrorMessage="Name is required")]
		[StringLength(64)]
		public object Name;
	}
}
