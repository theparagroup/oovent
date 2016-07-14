using System;

namespace Oovent.Models
{
	public partial class Url
	{
		public int Id { get; set;}
		public string UniformResourceLocator { get; set;}
		public int UrlTypeId { get; set;}
	}
}
