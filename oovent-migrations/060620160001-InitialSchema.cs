using System;
using FluentMigrator;
using com.paralib.Migrations;
using com.paralib.DataAnnotations;

namespace Oovent.Migrations
{
    [Migration(060620160001)]
    public class InitialSchema : Migration
    {
        public override void Down()
        {
            Delete.Table("entity_user_info");

            Delete.Table("entity_urls");
            Delete.Table("urls");
            Delete.Table("url_types");

            Delete.Table("event_entity_relationships");
            Delete.Table("event_entity_relationship_types");
            Delete.Table("events");
            Delete.Table("event_types");

            Delete.Table("entity_tags");
            Delete.Table("entity_entity_relationships");
            Delete.Table("entity_entity_relationship_types");
            Delete.Table("entities");            
            Delete.Table("entity_type_allowed_child_types");
            Delete.Table("entity_types");

            Delete.Table("tags");
        }

        public override void Up()
        {
            Create.Table("tags")
                .WithColumn("id").AsParaType(ParaTypes.Key).NotNullable().Identity().PrimaryKey()
                .WithColumn("parent_tag_id").AsParaType(ParaTypes.Key).Nullable().ForeignKey("tags", "id")
                .WithColumn("name").AsParaType(ParaTypes.Name).NotNullable();

            Create.Table("entity_types")
                .WithColumn("id").AsParaType(ParaTypes.Key).NotNullable().PrimaryKey()
                .WithColumn("name").AsParaType(ParaTypes.Name).NotNullable()
                .WithColumn("top_level_tag_id").AsParaType(ParaTypes.Key).Nullable();

            Create.Table("entity_type_allowed_child_types")
                .WithColumn("id").AsParaType(ParaTypes.Key).NotNullable().Identity().PrimaryKey()
                .WithColumn("parent_entity_type_id").AsParaType(ParaTypes.Key).NotNullable().ForeignKey("entity_types", "id")
                .WithColumn("child_entity_type_id").AsParaType(ParaTypes.Key).NotNullable().ForeignKey("entity_types", "id");

            Create.Table("entities")
                .WithColumn("id").AsParaType(ParaTypes.Key).NotNullable().Identity().PrimaryKey()
                .WithColumn("parent_entity_id").AsParaType(ParaTypes.Key).Nullable().ForeignKey("entities", "id")
                .WithColumn("entity_type_id").AsParaType(ParaTypes.Key).NotNullable().ForeignKey("entity_types", "id")
                .WithColumn("name").AsParaType(ParaTypes.Name).NotNullable();

            Create.Table("entity_entity_relationship_types")
                .WithColumn("id").AsParaType(ParaTypes.Key).NotNullable().PrimaryKey()
                .WithColumn("name").AsParaType(ParaTypes.Name).NotNullable();

            Create.Table("entity_entity_relationships")
                .WithColumn("id").AsParaType(ParaTypes.Key).NotNullable().Identity().PrimaryKey()
                .WithColumn("entity1_id").AsParaType(ParaTypes.Key).NotNullable().ForeignKey("entities", "id")
                .WithColumn("entity_entity_relationship_type_id").AsParaType(ParaTypes.Key).NotNullable().ForeignKey("entity_entity_relationship_types", "id")
                .WithColumn("entity2_id").AsParaType(ParaTypes.Key).NotNullable().ForeignKey("entities", "id");

            Create.Table("entity_tags")
                .WithColumn("id").AsParaType(ParaTypes.Key).NotNullable().Identity().PrimaryKey()
                .WithColumn("entity_id").AsParaType(ParaTypes.Key).NotNullable().ForeignKey("entities", "id")
                .WithColumn("tag_id").AsParaType(ParaTypes.Key).NotNullable().ForeignKey("tags", "id");

            Create.Table("event_types")
                .WithColumn("id").AsParaType(ParaTypes.Key).NotNullable().PrimaryKey()
                .WithColumn("name").AsParaType(ParaTypes.Name).NotNullable();

            Create.Table("events")
                .WithColumn("id").AsParaType(ParaTypes.Key).NotNullable().Identity().PrimaryKey()
                .WithColumn("parent_event_id").AsParaType(ParaTypes.Key).Nullable().ForeignKey("events", "id")
                .WithColumn("event_type_id").AsParaType(ParaTypes.Key).NotNullable().ForeignKey("event_types", "id")
                .WithColumn("description").AsParaType(ParaTypes.Description).NotNullable()
                .WithColumn("start").AsParaType(ParaTypes.DateTime).NotNullable()
                .WithColumn("end").AsParaType(ParaTypes.DateTime).NotNullable()
                .WithColumn("ordinal").AsParaType(ParaTypes.Int32).NotNullable()
                .WithColumn("m").AsParaType(ParaTypes.Bool).NotNullable()
                .WithColumn("t").AsParaType(ParaTypes.Bool).NotNullable()
                .WithColumn("w").AsParaType(ParaTypes.Bool).NotNullable()
                .WithColumn("th").AsParaType(ParaTypes.Bool).NotNullable()
                .WithColumn("f").AsParaType(ParaTypes.Bool).NotNullable()
                .WithColumn("s").AsParaType(ParaTypes.Bool).NotNullable()
                .WithColumn("su").AsParaType(ParaTypes.Bool).NotNullable();

            Create.Table("event_entity_relationship_types")
                .WithColumn("id").AsParaType(ParaTypes.Key).NotNullable().PrimaryKey()
                .WithColumn("name").AsParaType(ParaTypes.Name).NotNullable();

            Create.Table("event_entity_relationships")
                .WithColumn("id").AsParaType(ParaTypes.Key).NotNullable().Identity().PrimaryKey()
                .WithColumn("event_id").AsParaType(ParaTypes.Key).NotNullable().ForeignKey("events", "id")
                .WithColumn("event_entity_relationship_type_id").AsParaType(ParaTypes.Key).NotNullable().ForeignKey("event_entity_relationship_types", "id")
                .WithColumn("entity_id").AsParaType(ParaTypes.Key).NotNullable().ForeignKey("entities", "id");

            Create.Table("url_types")
                .WithColumn("id").AsParaType(ParaTypes.Key).NotNullable().PrimaryKey()
                .WithColumn("name").AsParaType(ParaTypes.Name).NotNullable();

            Create.Table("urls")
                .WithColumn("id").AsParaType(ParaTypes.Key).NotNullable().Identity().PrimaryKey()
                .WithColumn("url").AsParaType(ParaTypes.Url).NotNullable()
                .WithColumn("url_type_id").AsParaType(ParaTypes.Key).NotNullable().ForeignKey("url_types", "id");

            Create.Table("entity_urls")
                .WithColumn("id").AsParaType(ParaTypes.Key).NotNullable().Identity().PrimaryKey()
                .WithColumn("entity_id").AsParaType(ParaTypes.Key).NotNullable().ForeignKey("entities", "id")
                .WithColumn("url_id").AsParaType(ParaTypes.Key).NotNullable().ForeignKey("urls", "id");

            Create.Table("entity_user_info")
                .WithColumn("id").AsParaType(ParaTypes.Key).PrimaryKey().Identity().ForeignKey("entities", "id")
                .WithColumn("email").AsParaType(ParaTypes.Email).NotNullable()
                .WithColumn("password").AsParaType(ParaTypes.Password).NotNullable();


        }

    }
}
