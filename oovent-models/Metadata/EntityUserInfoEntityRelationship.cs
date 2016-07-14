using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using com.paralib.DataAnnotations;
using Oovent.Models.Metadata;


namespace Oovent.Models
{
	[MetadataType(typeof(EntityUserInfoEntityRelationshipMetadata))]
	public partial class EntityUserInfoEntityRelationship
	{
	}
}

namespace Oovent.Models.Metadata
{
	public class EntityUserInfoEntityRelationshipMetadata
	{

		[Key, Column(Order = 0)]
		[Display(Name="Id")]
		[Required(ErrorMessage="Id is required")]
		public object Id;

		[Display(Name="Entity Id")]
		[Required(ErrorMessage="Entity Id is required")]
		public object EntityId;

		[Display(Name="Entity User Info")]
		[Required(ErrorMessage="Entity User Info is required")]
		public object EntityUserInfo;
	}
}
