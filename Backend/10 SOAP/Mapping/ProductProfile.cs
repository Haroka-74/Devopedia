using AutoMapper;
using _01_SOAP.DTOs;
using _01_SOAP.Models;

namespace _01_SOAP.Mapping
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