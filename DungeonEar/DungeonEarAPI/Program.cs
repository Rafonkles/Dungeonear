using DungeonEarAPI.Database;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<DungeonEarDatabaseContext>(options =>{
    options.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=dungeonear;Trusted_Connection=True;");
});

var app = builder.Build();


// Configure the HTTP request pipeline.

app.UseCors(x => x.AllowAnyMethod().AllowAnyHeader().AllowAnyOrigin());
app.UseAuthorization();

app.MapControllers();

app.Run();
