using Microsoft.EntityFrameworkCore;
using VestgrensaSkjerm.Data;
using VestgrensaSkjerm.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors();

// Retrieving connection strings
var dbConnectionString = builder.Configuration.GetSection("Database:DbConnectionString").Value;

// Setting up database context
builder.Services.AddDbContext<VestgrensaDataContext>((services, builder) =>
{
    builder.UseNpgsql(dbConnectionString);
}, ServiceLifetime.Transient);
// Setting up the services as singleton
builder.Services.AddTransient<ResidentService>();
builder.Services.AddTransient<MessageService>();

var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    Console.Write("Running Application in Development Mode\n");
    app.UseSwagger();
    app.UseSwaggerUI();
}

// app.UseHttpsRedirection();
app.UseCors(builder => builder
    .AllowAnyOrigin()
    .AllowAnyHeader()
    .AllowAnyMethod());

app.UseAuthorization();

app.MapControllers();

app.Run();