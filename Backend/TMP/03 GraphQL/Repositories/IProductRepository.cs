using _03_GraphQL.Models;

namespace _03_GraphQL.Repositories
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
        Product? GetById(Guid id);
        Product Add(Product product);
        void Delete(Guid id);
    }
}