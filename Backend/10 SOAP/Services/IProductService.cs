using _01_SOAP.DTOs;
using System.ServiceModel;

namespace _01_SOAP.Services
{
    [ServiceContract]
    public interface IProductService
    {
        [OperationContract]
        IEnumerable<ProductDTO> GetProducts();

        [OperationContract]
        ProductDTO? GetProduct(Guid id);

        [OperationContract]
        ProductDTO AddProduct(CreateProductDTO createProductDTO);

        [OperationContract]
        void DeleteProduct(Guid id);
    }
}