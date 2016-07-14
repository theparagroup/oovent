using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using com.paralib.DataAnnotations;
using Oovent.Models.Metadata;


namespace Oovent.Models
{
	[MetadataType(typeof(EntityUserInfoMetadata))]
	public partial class EntityUserInfo
	{
	}
}

namespace Oovent.Models.Metadata
{
	public class EntityUserInfoMetadata
	{

		[Key, Column(Order = 0)]
		[Display(Name="Id")]
		[Required(ErrorMessage="Id is required")]
		public object Id;

		[Display(Name="Email")]
		[Required(ErrorMessage="Email is required")]
		[StringLength(254)]
		public object Email;

		[Display(Name="Password")]
		[Required(ErrorMessage="Password is required")]
		[StringLength(128)]
		public object Password;
	}
}
