// Import necessary namespaces
using grupoaApi.Context;
using Microsoft.EntityFrameworkCore;

// Create a new web application builder
var builder = WebApplication.CreateBuilder(args);

// Add services to the container
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer(); // Add API explorer to the services
builder.Services.AddSwaggerGen(); // Add Swagger generation to the services

// Add services to the container.
var mySqlConnection = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContextPool<AppDbContext>(options =>
    options.UseMySql(mySqlConnection, ServerVersion.AutoDetect(mySqlConnection))); // Add MySQL connection to the services

// cors 
builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy",
        builder => builder
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());
});

// Add the application controllers with views to the services
builder.Services.AddControllersWithViews(); // Add controllers with views to the services

// Build the application
var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger(); // Use Swagger in development environment
    app.UseSwaggerUI(); // Use Swagger UI in development environment
    app.UseCors("CorsPolicy");
}

app.Student(); // Handle student request

// Run the application
app.Run(  );