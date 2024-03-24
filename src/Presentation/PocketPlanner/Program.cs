using Microsoft.EntityFrameworkCore;
using PocketPlanner.Persistence;

var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddPersistence();

builder.AddSqlServerDbContext<PocketPlannerContext>("PocketPlannerDb", configureDbContextOptions: options =>
{
    options.UseSqlServer(sqlServerOptions =>
    {
        sqlServerOptions.MigrationsAssembly("PocketPlanner.Persistence");
    });
});
var app = builder.Build();

app.MapDefaultEndpoints();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
