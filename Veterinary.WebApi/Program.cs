using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Veterinary.Infraestructure.Services;
using Veterinary.Infrastructure.Data;
using Veterinary.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//Inyeccion de dependencia al contexto
builder.Services.AddDbContext<VeterinaryContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DbContext") 
    ?? throw new InvalidOperationException("Connection string 'DbContext' not found.")));

builder.Services.AddTransient <IClientRepository, ClientRepository > ();
//la inyeccion de dependencia se pueden hacer de distintas formas segun se requiera

builder.Services.AddControllers();

//inyeccion de Dependencia de FluetValidator
builder.Services.AddFluentValidationClientsideAdapters();
builder.Services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());//typeof(Program).Assembly estaba escrito así cuando lo encontre por las dudas lo dejamos
//todas las clases que hereden de  AbstractValidator, esto lo va a tomar como validaciones


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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
