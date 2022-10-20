using Microsoft.EntityFrameworkCore;
using NightMaker.ProjectQueen_sBox.Core.Repositories;
using NightMaker.ProjectQueen_sBox.Core.Services;
using NightMaker.ProjectQueen_sBox.Repository.DbContexts;
using NightMaker.ProjectQueen_sBox.Repository.Repositories;
using NightMaker.ProjectQueen_sBox.Service.Services;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped(typeof(IGenericService<>), typeof(GenericService<>));

builder.Services.AddDbContext<SqlServerDbContext>(x =>
{
    x.UseSqlServer(builder.Configuration.GetConnectionString("SqlServerConnectionString"), option =>
    {
        // Get me Assembly (App) that has SqlServerDbContext in it.
        option.MigrationsAssembly(Assembly.GetAssembly(typeof(SqlServerDbContext)).GetName().Name);
    });
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    //app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
