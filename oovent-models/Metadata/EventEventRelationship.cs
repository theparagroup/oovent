using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using com.paralib.DataAnnotations;
using Oovent.Models.Metadata;


namespace Oovent.Models
{
	[MetadataType(typeof(EventEventRelationshipMetadata))]
	public partial class EventEventRelationship
	{
	}
}

namespace Oovent.Models.Metadata
{
	public class EventEventRelationshipMetadata
	{

		[Key, Column(Order = 0)]
		[Display(Name="Id")]
		[Required(ErrorMessage="Id is required")]
		public object Id;

		[Display(Name="Event Id A")]
		[Required(ErrorMessage="Event Id A is required")]
		public object EventIdA;

		[Display(Name="Event Event Relationship Type Id")]
		[Required(ErrorMessage="Event Event Relationship Type Id is required")]
		public object EventEventRelationshipTypeId;

		[Display(Name="Event Id B")]
		[Required(ErrorMessage="Event Id B is required")]
		public object EventIdB;
	}
}
