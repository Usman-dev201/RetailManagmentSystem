using Microsoft.AspNetCore.Mvc;
using RMS.Models;
using RMS.Models.Entities;

namespace RMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }
        private static List<Product> products = new List<Product>();

        [HttpPost]
        public async Task<ActionResult<Product>> PostProduct(Product product)
        {
            product.CreatedAt = DateTime.UtcNow; // Set current date and time

            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            return CreatedAtAction
                (nameof(PostProduct), 
                new { id = product.ProductId }, 
                product);
        }
    }
}

