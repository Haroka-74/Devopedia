using AutoMapper;
using _03_GraphQL.Types;
using _03_GraphQL.Models;
using _03_GraphQL.Repositories;

namespace _03_GraphQL.GraphQL
{
    public class Mutation
    {
        public Product AddProduct(
            CreateProductInput input,
            [Service] IProductRepository repository,
            [Service] IMapper mapper)
        {
            var product = mapper.Map<Product>(input);
            repository.Add(product);
            return product;
        }

        public bool DeleteProduct(Guid id, [Service] IProductRepository repository)
        {
            repository.Delete(id);
            return true;
        }
    }
}