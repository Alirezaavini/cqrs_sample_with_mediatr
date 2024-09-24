using Microsoft.Extensions.DependencyInjection;
using System.Reflection;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMediatR(typeof(Program).Assembly);

var app = builder.Build();


app.MapGet("/", () => "Hello World!");


app.Run();
