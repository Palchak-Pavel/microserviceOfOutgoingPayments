using System.Reflection;
using FluentValidation;
using FluentValidation.AspNetCore;
using microserviceOfOutgoingPayments.Mongodb;
using microserviceOfOutgoingPayments.Mongodb.Data;

EntitiesConfig.Config();
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IMongoIncomePaymentContext, IncomePaymentContext>();

builder.Services.AddControllers();
builder.Services.AddFluentValidation();
builder.Services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());;

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

