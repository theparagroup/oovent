using System;
using FluentMigrator;
using com.paralib.Migrations;
using com.paralib.DataAnnotations;

namespace Oovent.Migrations
{
    public class InitialPopulation : Migration
    {
        public override void Down()
        {
            
        }

        public override void Up()
        {
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
    }
}
