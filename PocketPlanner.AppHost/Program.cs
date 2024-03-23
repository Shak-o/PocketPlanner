var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.PocketPlanner>("pocketplanner");

builder.Build().Run();
