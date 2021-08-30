using AutoMapper;
using MediatR;
using OnionArchitectureProject.Application.Dto;
using OnionArchitectureProject.Application.Interfaces.Repository;
using OnionArchitectureProject.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OnionArchitectureProject.Application.Features.Queries.GetAllProducts
{
    public class GetAllProductsQuery : IRequest<ServiceResponse<List<ProductViewDto>>>
    {

        public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, ServiceResponse<List<ProductViewDto>>>
        {
            private readonly IProductRepository productRepository;
            private readonly IMapper mapper;

            public GetAllProductsQueryHandler(IProductRepository productRepository, IMapper mapper)
            {
                this.productRepository = productRepository;
                this.mapper = mapper;
            }

            public async Task<ServiceResponse<List<ProductViewDto>>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
            {
                var products = await productRepository.GetAllAsync();
                var productDto = mapper.Map<List<ProductViewDto>>(products); 

                //var productDto = products.Select(x => new ProductViewDto
                //{
                //    Id = x.Id,
                //    Name = x.Name
                //}).ToList();

                return new ServiceResponse<List<ProductViewDto>>(productDto);
            }
        }
    }
}
