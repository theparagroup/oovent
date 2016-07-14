using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using com.paralib.DataAnnotations;
using Oovent.Models.Metadata;


namespace Oovent.Models
{
	[MetadataType(typeof(EventMetadata))]
	public partial class Event
	{
	}
}

namespace Oovent.Models.Metadata
{
	public class EventMetadata
	{

		[Key, Column(Order = 0)]
		[Display(Name="Id")]
		[Required(ErrorMessage="Id is required")]
		public object Id;

		[Display(Name="Parent Event Id")]
		[Required(ErrorMessage="Parent Event Id is required")]
		public object ParentEventId;

		[Display(Name="Event Type Id")]
		[Required(ErrorMessage="Event Type Id is required")]
		public object EventTypeId;

		[Display(Name="Description")]
		[Required(ErrorMessage="Description is required")]
		public object Description;

		[Display(Name="Start")]
		[Required(ErrorMessage="Start is required")]
		public object Start;

		[Display(Name="End")]
		[Required(ErrorMessage="End is required")]
		public object End;

		[Display(Name="Ordinal")]
		[Required(ErrorMessage="Ordinal is required")]
		public object Ordinal;

		[Display(Name="M")]
		[Required(ErrorMessage="M is required")]
		public object M;

		[Display(Name="T")]
		[Required(ErrorMessage="T is required")]
		public object T;

		[Display(Name="W")]
		[Required(ErrorMessage="W is required")]
		public object W;

		[Display(Name="Th")]
		[Required(ErrorMessage="Th is required")]
		public object Th;

		[Display(Name="F")]
		[Required(ErrorMessage="F is required")]
		public object F;

		[Display(Name="S")]
		[Required(ErrorMessage="S is required")]
		public object S;

		[Display(Name="Su")]
		[Required(ErrorMessage="Su is required")]
		public object Su;
	}
}
