using Models;

namespace Services
{
    public interface IProductService
    {
        ICollection<Product> GetProducts();
        Product? GetProduct(int id);
        void AddProduct(Product product);
        void DeleteProduct(int id);
    }
}