using BeDauThau.Implement;
using BeDauThau.Interface;
using BeDauThau.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();







builder.Services.AddDbContext<DauThauContext>(opt =>
{
    opt.UseSqlServer("Data Source=DESKTOP-0BBMM3F\\MSSQLSERVERLOCAL;Initial Catalog=DauThau;Integrated Security=True;Trust Server Certificate=True");
});
builder.Services.AddScoped<IMainService, MainService>();
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
