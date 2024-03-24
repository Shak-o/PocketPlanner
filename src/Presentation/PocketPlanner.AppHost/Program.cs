var builder = DistributedApplication.CreateBuilder(args);

var sqlServer = builder.AddSqlServer("PocketPlannerDbConnection", "Aa123456").AddDatabase("PocketPlannerDb");
var pocketPlanner = builder.AddProject<Projects.PocketPlanner>("pocketplanner")
    .WithReference(sqlServer);
var migrations = builder.AddProject<Projects.PocketPlanner_MigrationService>("pocketplannermigrations")
    .WithReference(sqlServer);

builder.Build().Run();
