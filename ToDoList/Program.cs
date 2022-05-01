using Microsoft.EntityFrameworkCore;
using ToDoList.Model;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
var conn = "ToDoDBContext";
builder.Services.AddDbContext<ToDoDBContext>(x => { x.UseSqlServer(builder.Configuration.GetConnectionString(conn)); });
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

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
