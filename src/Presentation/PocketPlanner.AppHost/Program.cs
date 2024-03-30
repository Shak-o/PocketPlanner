var builder = DistributedApplication.CreateBuilder(args);

var sqlServer = builder.AddConnectionString("PocketPlannerDb");

var pocketPlanner = builder.AddProject<Projects.PocketPlanner>("pocketplanner")
    //.WithReplicas(3)
    .WithReference(sqlServer);

builder.AddProject<Projects.PocketPlannerWeb>("pocketplannerweb")
    .WithReference(pocketPlanner);

builder.AddProject<Projects.PocketPlanner_MigrationService>("pocketplannermigrations")
    .WithReference(sqlServer);

builder.Build().Run();
