using System;
using FluentMigrator;
using com.paralib.Migrations;

namespace Oovent.Migrations
{
    [Migration(060820160001)]
    public class LoggingSupport : Migration
    {
        public override void Down()
        {
            //Delete.StandardLogTable();
        }

        public override void Up()
        {
            //Create.StandardLogTable();
        }
    }
}
