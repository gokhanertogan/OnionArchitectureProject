using AutoMapper;
using OnionArchitectureProject.Application.Dto;
using OnionArchitectureProject.Application.Features.Commands.CreateProduct;
using OnionArchitectureProject.Application.Features.Queries.GetProductById;
using OnionArchitectureProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArchitectureProject.Application.Mapping
{
    public class GeneralMapping :Profile
    {
        public GeneralMapping()
        {
            CreateMap<Product, ProductViewDto>().ReverseMap();

            CreateMap<Product, CreateProductCommand>().ReverseMap();

            CreateMap<Product, GetProductByIdViewModel>().ReverseMap();
        }

    }
}
