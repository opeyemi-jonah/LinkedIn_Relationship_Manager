using FluentAssertions.Common;
using LinkedIn_Relationship_Manager.Data;
using LinkedIn_Relationship_Manager.DBContext;
using LinkedIn_Relationship_Manager.Repositories.Implementation;
using LinkedIn_Relationship_Manager.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<DataContext>(options => options.UseSqlServer(connectionString));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// In your Startup.cs or ConfigureServices method
builder.Services.AddScoped<IUser, UserRepository>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    
    //Adding the DbInitializer on startup
    try
    {
        // Use a scope to resolve DataContext within the request scope
        using (var scope = app.Services.CreateScope())
        {
            var dbContext = scope.ServiceProvider.GetRequiredService<DataContext>();
            DbInitializer.Initialize(dbContext);
        }
    }
    catch (Exception ex)
    {
        var logger = app.Services.GetRequiredService<ILogger<Program>>();
        logger.LogError(ex, "An error occurred creating the DB.");
    }


}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
