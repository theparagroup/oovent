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

		[Display(Name="Entity Id A")]
		[Required(ErrorMessage="Entity Id A is required")]
		public object EntityIdA;

		[Display(Name="Entity Entity Relationship Type Id")]
		[Required(ErrorMessage="Entity Entity Relationship Type Id is required")]
		public object EntityEntityRelationshipTypeId;

		[Display(Name="Entity Id B")]
		[Required(ErrorMessage="Entity Id B is required")]
		public object EntityIdB;
	}
}
