using cqrs_sample_with_mediatr.Commands;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;


Console.WriteLine("App started");



var serviceProvider = new ServiceCollection()
            .AddMediatR(typeof(CreateProductCommand).Assembly) // Register MediatR handlers  
            .BuildServiceProvider();

// Resolve IMediatR instance  
var mediator = serviceProvider.GetRequiredService<IMediator>();

int newItemId = await mediator.Send(new CreateProductCommand { Name = "New Item", Price = 19.99m });

Console.WriteLine("after runing handler");


