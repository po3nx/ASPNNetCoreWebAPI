using Microsoft.EntityFrameworkCore;
using Application.Interfaces;
using Application.Services;
using Application.Mappings;
using Infrastructure.Data;
using Infrastructure.Repositories;
using Infrastructure.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(typeof(ApplicationMappingProfile));

// Add Application Services
builder.Services.AddScoped<IProductService, ProductService>();

// Add Repositories
builder.Services.AddScoped<IProductRepository, ProductRepository>();

// Add Database Configuration
builder.Services.AddDatabaseConfiguration(builder.Configuration);

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
