using AutoMapper;
using _02_REST.DTOs;
using _02_REST.Models;

namespace _02_REST.Mapping
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductDTO>();
            CreateMap<CreateProductDTO, Product>();
        }
    }
}