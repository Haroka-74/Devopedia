using AutoMapper;
using _03_GraphQL.Models;
using _03_GraphQL.Types;

namespace _03_GraphQL.Mapping
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<CreateProductInput, Product>();
        }
    }
}