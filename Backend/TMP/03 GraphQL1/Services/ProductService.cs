using Models;
using Repositories;

namespace Services
{
    public class ProductService(IProductRepository repository) : IProductService
    {
        private readonly IProductRepository _repository = repository;

        public ICollection<Product> GetProducts()
            => _repository.GetAll();

        public Product? GetProduct(int id)
            => _repository.GetById(id);

        public void AddProduct(Product product)
            => _repository.Add(product);

        public void DeleteProduct(int id)
            => _repository.Delete(id);
    }
}