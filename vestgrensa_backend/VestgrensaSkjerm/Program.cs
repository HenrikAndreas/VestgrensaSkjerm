using Microsoft.EntityFrameworkCore;
using VestgrensaSkjerm.Data;
using VestgrensaSkjerm.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Setting up database context
builder.Services.AddDbContext<VestgrensaDataContext>((services, builder) =>
{
    builder.UseNpgsql("Host=localhost;Port=5432;Database=vestgrensa;Username=henrik;Password=vestgrensa");
}, ServiceLifetime.Singleton);
// Setting up the services as singleton
builder.Services.AddSingleton<ResidentService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    Console.Write("Running Application in Development Mode\n");
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();