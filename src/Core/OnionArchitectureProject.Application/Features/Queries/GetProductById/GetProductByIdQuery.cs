using MediatR;
using OnionArchitectureProject.Application.Dto;
using OnionArchitectureProject.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArchitectureProject.Application.Features.Queries.GetProductById
{
    public class GetProductByIdQuery:IRequest<ServiceResponse<GetProductByIdViewModel>>
    {
        public Guid Id { get; set; }

    }
}
