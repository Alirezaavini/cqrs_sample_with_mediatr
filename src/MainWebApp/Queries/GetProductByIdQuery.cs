using MainWebApp.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainWebApp.Queries
{
    public class GetProductByIdQuery : IRequest<Product>
    {
        public int Id { get; set; }
    }


    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, Product>
    {

        public Task<Product> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new Product
            {
                Id = 1,
                Name = "Samsung Mobile A12",
                Price = 25000
            });

        }

    }
}
