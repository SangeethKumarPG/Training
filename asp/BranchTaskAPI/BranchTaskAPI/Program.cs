using BranchTaskAPI.DataAccess;
using BranchTaskAPI.Model;
using BranchTaskAPI.Repository;
using BranchTaskAPI.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddTransient<Branch>();
builder.Services.AddTransient<DataContext>();
builder.Services.AddTransient<BranchRepository>();
builder.Services.AddTransient<BranchService>();
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
