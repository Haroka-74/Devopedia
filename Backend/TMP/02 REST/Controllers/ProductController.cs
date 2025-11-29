using _02_REST.DTOs;
using _02_REST.Services;
using Microsoft.AspNetCore.Mvc;

namespace _02_REST.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController(IProductService service) : ControllerBase
    {
        [HttpGet]
        public IActionResult GetProducts()
            => Ok(service.GetProducts());

        [HttpGet("{id}")]
        public IActionResult GetProduct(Guid id)
            => Ok(service.GetProduct(id));

        [HttpPost]
        public IActionResult AddProduct(CreateProductDTO product)
        {
            var productDTO = service.AddProduct(product);
            return CreatedAtAction(nameof(GetProduct), new { id = productDTO.Id }, productDTO);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(Guid id)
        {
            service.DeleteProduct(id);
            return NoContent();
        }
    }
}