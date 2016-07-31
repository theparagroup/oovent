using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using com.paralib.DataAnnotations;
using Oovent.Models.Metadata;


namespace Oovent.Models
{
	[MetadataType(typeof(EntityEntityRelationshipMetadata))]
	public partial class EntityEntityRelationship
	{
	}
}

namespace Oovent.Models.Metadata
{
	public class EntityEntityRelationshipMetadata
	{

		[Key, Column(Order = 0)]
		[Display(Name="Id")]
		[Required(ErrorMessage="Id is required")]
		public object Id;

		[Display(Name="Entity A Id")]
		[Required(ErrorMessage="Entity A Id is required")]
		public object EntityAId;

		[Display(Name="Entity Entity Relationship Type Id")]
		[Required(ErrorMessage="Entity Entity Relationship Type Id is required")]
		public object EntityEntityRelationshipTypeId;

		[Display(Name="Entity B Id")]
		[Required(ErrorMessage="Entity B Id is required")]
		public object EntityBId;
	}
}
