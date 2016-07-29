using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using com.paralib.DataAnnotations;
using Oovent.Models.Metadata;


namespace Oovent.Models
{
	[MetadataType(typeof(EventEntityRelationshipMetadata))]
	public partial class EventEntityRelationship
	{
	}
}

namespace Oovent.Models.Metadata
{
	public class EventEntityRelationshipMetadata
	{

		[Key, Column(Order = 0)]
		[Display(Name="Id")]
		[Required(ErrorMessage="Id is required")]
		public object Id;

		[Display(Name="Event Id")]
		[Required(ErrorMessage="Event Id is required")]
		public object EventId;

		[Display(Name="Event Entity Relationship Type Id")]
		[Required(ErrorMessage="Event Entity Relationship Type Id is required")]
		public object EventEntityRelationshipTypeId;

		[Display(Name="Entity Id")]
		[Required(ErrorMessage="Entity Id is required")]
		public object EntityId;
	}
}
