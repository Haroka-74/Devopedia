using Models;

namespace Repositories
{
    public interface IProductRepository
    {
        ICollection<Product> GetAll();
        Product? GetById(int id);
        void Add(Product product);
        void Delete(int id);
    }
}