using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainWebApp.Commands
{

    // Command to create a new product
    public class CreateProductCommand : IRequest<int>
    {

        public string Name { get; set; } = default!;

        public decimal Price { get; set; }
    }


    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, int>   //<input object,response>
    {

        public Task<int> Handle(CreateProductCommand createProductCommand, CancellationToken cancellationToken)
        {
            Console.WriteLine("I am handler");


            return Task.FromResult(1);
        }

    }


}
