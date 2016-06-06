using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentMigrator;

namespace Oovent.Migrations
{
    [Migration(06062016)]
    public class Migration06062016 : Migration
    {
        public override void Up()
        {
            Create.Table("tags")
                .WithColumn("id").AsInt32().NotNullable().Identity().PrimaryKey()
                .WithColumn("parent_tag_id").AsInt32().Nullable()
                .WithColumn("name").AsString().NotNullable();

            Create.Table("entity_types")
                .WithColumn("id").AsInt32().NotNullable().PrimaryKey()
                .WithColumn("name").AsString().NotNullable()
                .WithColumn("top_level_tag_id").AsInt32().Nullable();

            Create.Table("entity_type_allowed_child_types")
                .WithColumn("id").AsInt32().NotNullable().Identity().PrimaryKey()
                .WithColumn("parent_entity_type_id").AsInt32().NotNullable().ForeignKey("entity_types", "id")
                .WithColumn("child_entity_type_id").AsInt32().NotNullable().ForeignKey("entity_types", "id");

            Create.Table("entities")
                .WithColumn("id").AsInt32().NotNullable().Identity().PrimaryKey()
                .WithColumn("parent_entity_id").AsInt32().NotNullable().ForeignKey("entities", "id")
                .WithColumn("entity_type_id").AsInt32().NotNullable().ForeignKey("entity_types", "id")
                .WithColumn("name").AsString().NotNullable();

            Create.Table("entity_tags")
                .WithColumn("id").AsInt32().NotNullable().Identity().PrimaryKey()
                .WithColumn("entity_id").AsInt32().NotNullable().ForeignKey("entities", "id")
                .WithColumn("tag_id").AsInt32().NotNullable().ForeignKey("tags", "id");

            Create.Table("entity_user_info")
                .WithColumn("id").AsInt32().NotNullable().Identity().PrimaryKey()
                .WithColumn("entity_id").AsInt32().Nullable().ForeignKey("entities", "id")
                .WithColumn("email").AsString().NotNullable()
                .WithColumn("password").AsString().NotNullable().GetHashCode();

            Create.Table("url_types")
                .WithColumn("id").AsInt32().NotNullable().PrimaryKey()
                .WithColumn("name").AsString().NotNullable();

            Create.Table("urls")
                .WithColumn("id").AsInt32().NotNullable().Identity().PrimaryKey()
                .WithColumn("url").AsString().NotNullable()
                .WithColumn("url_type_id").AsInt32().NotNullable().ForeignKey("url_types", "id");

            Create.Table("entity_urls")
                .WithColumn("id").AsInt32().NotNullable().Identity().PrimaryKey()
                .WithColumn("entity_id").AsInt32().NotNullable().ForeignKey("entities", "id")
                .WithColumn("url_id").AsInt32().NotNullable().ForeignKey("urls", "id");

            Create.Table("event_types")
                .WithColumn("id").AsInt32().NotNullable().PrimaryKey()
                .WithColumn("name").AsString().NotNullable();

            Create.Table("events")
                .WithColumn("id").AsInt32().NotNullable().Identity().PrimaryKey()
                .WithColumn("parent_event_id").AsInt32().NotNullable().ForeignKey("events", "id")
                .WithColumn("event_type_id").AsInt32().NotNullable().ForeignKey("event_types", "id")
                .WithColumn("description").AsString().NotNullable()
                .WithColumn("start").AsDate().NotNullable()
                .WithColumn("end").AsDate().NotNullable()
                .WithColumn("ordinal").AsInt32().NotNullable()
                .WithColumn("m").AsBoolean().NotNullable()
                .WithColumn("t").AsBoolean().NotNullable()
                .WithColumn("w").AsBoolean().NotNullable()
                .WithColumn("th").AsBoolean().NotNullable()
                .WithColumn("f").AsBoolean().NotNullable()
                .WithColumn("s").AsBoolean().NotNullable()
                .WithColumn("su").AsBoolean().NotNullable();

            Create.Table("event_relationship_types")
                .WithColumn("id").AsInt32().NotNullable().PrimaryKey()
                .WithColumn("name").AsString().NotNullable();

            Create.Table("event_entity_relationships")
                .WithColumn("id").AsInt32().NotNullable().Identity().PrimaryKey()
                .WithColumn("event_id").AsInt32().NotNullable().ForeignKey("events", "id")
                .WithColumn("event_relationship_type_id").AsInt32().NotNullable().ForeignKey("event_relationship_types", "id")
                .WithColumn("entity_id").AsInt32().NotNullable().ForeignKey("entities", "id");

            Insert.IntoTable("entity_types")
                .Row(new { id = "0", name = "User" })
                .Row(new { id = "1", name = "Source" })
                .Row(new { id = "2", name = "Special" })
                .Row(new { id = "3", name = "Performance" })
                .Row(new { id = "4", name = "Meeting" })
                .Row(new { id = "5", name = "Festival" })
                .Row(new { id = "6", name = "Location" })
                .Row(new { id = "7", name = "Business" })
                .Row(new { id = "8", name = "Educational Institution" })
                .Row(new { id = "9", name = "Governmental Institution" })
                .Row(new { id = "10", name = "Civic Institution" })
                .Row(new { id = "11", name = "Band" })
                .Row(new { id = "12", name = "Food Truck" })
                .Row(new { id = "13", name = "Other Entity" });

            Insert.IntoTable("url_types")
                .Row(new { id = "0", name = "Web" })
                .Row(new { id = "1", name = "Twitter" })
                .Row(new { id = "2", name = "Facebook" })
                .Row(new { id = "3", name = "Pinterest" })
                .Row(new { id = "4", name = "Tumblr" })
                .Row(new { id = "5", name = "Instagram" })
                .Row(new { id = "6", name = "Other" });

            Insert.IntoTable("event_types")
                .Row(new { id = "0", name = "One Time" })
                .Row(new { id = "1", name = "Weekly" })
                .Row(new { id = "2", name = "Monthly" });

            Insert.IntoTable("event_relationship_types")
                .Row(new { id = "0", name = "Organized By" })
                .Row(new { id = "1", name = "Featuring" })
                .Row(new { id = "2", name = "Sponsored By" })
                .Row(new { id = "3", name = "Assigned To" })
                .Row(new { id = "4", name = "Offering" })
                .Row(new { id = "5", name = "Owned By" })
                .Row(new { id = "6", name = "Created By" })
                .Row(new { id = "7", name = "Located At" });            
        }
        public override void Down()
        {
            Delete.Table("event_entity_relationships");
            Delete.Table("event_relationship_types");
            Delete.Table("events");
            Delete.Table("event_types");
            Delete.Table("entity_urls");
            Delete.Table("urls");
            Delete.Table("url_types");
            Delete.Table("entity_user_info");
            Delete.Table("entity_tags");
            Delete.Table("entities");
            Delete.Table("entity_type_allowed_child_types");
            Delete.Table("entity_types");
            Delete.Table("tags");
        }
    }
}
