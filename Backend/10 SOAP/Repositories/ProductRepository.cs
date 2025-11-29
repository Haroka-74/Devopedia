using _01_SOAP.Data;
using _01_SOAP.Models;

namespace _01_SOAP.Repositories
{
    public class ProductRepository(ProductDbContext context) : IProductRepository
    {
        public IEnumerable<Product> GetAll()
            => context.Products.Where(p => p.Stock > 0);

        public Product? GetById(Guid id)
            => context.Products.Find(id);

        public Product Add(Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
            return product;
        }

        public void Delete(Guid id)
        {
            var product = GetById(id);

            if(product is not null)
            {
                context.Products.Remove(product);
                context.SaveChanges();
            }
        }
    }
}