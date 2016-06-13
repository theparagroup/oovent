using System;
using FluentMigrator;
using com.paralib.Migrations.Logging;

namespace Oovent.Migrations
{
    [Migration(060820160001)]
    public class LoggingSupport : Migration
    {
        public override void Down()
        {
            MvcLogging.Down(this);
        }

        public override void Up()
        {
            MvcLogging.Up(this);
        }
    }
}
