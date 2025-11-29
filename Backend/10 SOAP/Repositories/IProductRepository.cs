using _01_SOAP.Models;

namespace _01_SOAP.Repositories
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
        Product? GetById(Guid id);
        Product Add(Product product);
        void Delete(Guid id);
    }
}