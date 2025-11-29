using _02_REST.DTOs;

namespace _02_REST.Services
{
    public interface IProductService
    {
        IEnumerable<ProductDTO> GetProducts();
        ProductDTO? GetProduct(Guid id);
        ProductDTO AddProduct(CreateProductDTO createProductDTO);
        void DeleteProduct(Guid id);
    }
}