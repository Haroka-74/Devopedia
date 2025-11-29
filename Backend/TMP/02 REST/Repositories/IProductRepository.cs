using _02_REST.Models;

namespace _02_REST.Repositories
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
        Product? GetById(Guid id);
        Product Add(Product product);
        void Delete(Guid id);
    }
}