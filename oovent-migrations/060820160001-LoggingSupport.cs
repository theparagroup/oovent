using System;
using FluentMigrator;
using com.paralib.migrations;

namespace Oovent.Migrations
{
    [Migration(060820160001)]
    public class LoggingSupport : Migration
    {
        public override void Down()
        {
            Logging.Down(this);
        }

        public override void Up()
        {
            Logging.Up(this);
        }
    }
}
