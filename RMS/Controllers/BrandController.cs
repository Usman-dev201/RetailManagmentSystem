using Microsoft.AspNetCore.Mvc;
using RMS.Models;
using RMS.Models.Entities;

namespace RMS.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class BrandController : Controller
    {
       private readonly ApplicationDbContext _context;
        public BrandController(ApplicationDbContext context)
        {
            _context = context;
        }
        private static List<Brand> brands = new List<Brand>();

        [HttpPost]
        public async Task<ActionResult<Brand>> PostBrand(Brand brand)
        {
            _context.Brands.Add(brand);
            await _context.SaveChangesAsync();

            return CreatedAtAction
                (nameof(PostBrand),
                new { id = brand.BrandId },
                brand);
        }

    }
}
