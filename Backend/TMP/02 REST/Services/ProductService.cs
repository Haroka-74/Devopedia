using AutoMapper;
using _02_REST.DTOs;
using _02_REST.Models;
using _02_REST.Repositories;

namespace _02_REST.Services
{
    public class ProductService(IMapper mapper, IProductRepository repository) : IProductService
    {
        public IEnumerable<ProductDTO> GetProducts()
            => mapper.Map<IEnumerable<ProductDTO>>(repository.GetAll());

        public ProductDTO? GetProduct(Guid id)
            => mapper.Map<ProductDTO>(repository.GetById(id));

        public ProductDTO AddProduct(CreateProductDTO createProductDTO)
        {
            var product = mapper.Map<Product>(createProductDTO);
            repository.Add(product);
            return mapper.Map<ProductDTO>(product);
        }

        public void DeleteProduct(Guid id)
            => repository.Delete(id);
    }
}