..\packages\FluentMigrator.1.6.2\tools\Migrate.exe /conn "Data Source=.\SQLEXPRESS;Initial Catalog=oovent;Integrated Security=True" /provider SqlServer2012 /assembly bin\Debug\oovent-migrations.dll /task rollback:all

..\packages\FluentMigrator.1.6.2\tools\Migrate.exe /conn "Data Source=.\SQLEXPRESS;Initial Catalog=oovent;Integrated Security=True" /provider SqlServer2012 /assembly bin\Debug\oovent-migrations.dll /task migrate