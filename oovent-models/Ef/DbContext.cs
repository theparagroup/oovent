using System;
using System.Data.Entity;
using com.paralib.Dal.Ef;

namespace Oovent.Models.Ef
{
	[DbConfigurationType(typeof(EfConfiguration))]
	public class DbContext:EfContext
	{

#if DEBUG
		public DbContext()
		{
			Database.Log = message => System.Diagnostics.Debug.WriteLine(message);
		}
#endif

		public DbSet<EfTag> Tags { get; set; }
		public DbSet<EfEntityType> EntityTypes { get; set; }
		public DbSet<EfEntityTypeAllowedChildType> EntityTypeAllowedChildTypes { get; set; }
		public DbSet<EfEntity> Entities { get; set; }
		public DbSet<EfEntityTag> EntityTags { get; set; }
		public DbSet<EfEventType> EventTypes { get; set; }
		public DbSet<EfEvent> Events { get; set; }
		public DbSet<EfEventEntityRelationshipType> EventEntityRelationshipTypes { get; set; }
		public DbSet<EfEventEntityRelationship> EventEntityRelationships { get; set; }
		public DbSet<EfEntityEntityRelationshipType> EntityEntityRelationshipTypes { get; set; }
		public DbSet<EfEntityEntityRelationship> EntityEntityRelationships { get; set; }
		public DbSet<EfEventEventRelationshipType> EventEventRelationshipTypes { get; set; }
		public DbSet<EfEventEventRelationship> EventEventRelationships { get; set; }
		public DbSet<EfEventTypeEntityTypeTag> EventTypeEntityTypeTags { get; set; }
		public DbSet<EfUrlType> UrlTypes { get; set; }
		public DbSet<EfUrl> Urls { get; set; }
		public DbSet<EfEntityUrl> EntityUrls { get; set; }
		public DbSet<EfEventUrl> EventUrls { get; set; }
		public DbSet<EfEntityUserInfo> EntityUserInfo { get; set; }
	}
}
