using _03_GraphQL.Models;
using _03_GraphQL.Repositories;

namespace _03_GraphQL.GraphQL
{
    public class Query
    {
        public IEnumerable<Product> GetProducts([Service] IProductRepository repository)
            => repository.GetAll();

        public Product? GetProduct(Guid id, [Service] IProductRepository repository)
            => repository.GetById(id);
    }
}