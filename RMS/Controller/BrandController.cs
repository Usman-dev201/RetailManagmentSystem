using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RMS.AddModels.AddEntities;
using RMS.Models;
using RMS.Models.Entities;

namespace RMS.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class BrandController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public BrandController(ApplicationDbContext context)
        {
            _context = context;
        }
        public static List<Brand> Brands = new List<Brand>();

        [HttpGet]
        public async Task<IActionResult> GetAllBrands()
        {
            var brands = await _context.Brands.ToListAsync();
            if (brands == null || brands.Count == 0)
            {
                return BadRequest("BrandName is Required");
            }
            return Ok(brands);

        }
        [HttpGet("{id}", Name = "GetBrand")]
        public async Task<IActionResult> GetBrandById(int id)
        {
            var brand = await _context.Brands.FindAsync(id);
            if (brand == null)
            {
                return NotFound();
            }
            return Ok(brand);
        }
        [HttpPost]
        public async Task<IActionResult> AddBrand([FromBody] AddBrand addBrand)
        {
            if (addBrand == null || string.IsNullOrWhiteSpace(addBrand.BrandName))

            {
                return BadRequest("Brand Name is required");
            }
            var brand = new Brand
            {
                BrandName = addBrand.BrandName,
            };
            _context.Brands.Add(brand);
            await _context.SaveChangesAsync();
            return CreatedAtRoute(
                "GetBrand",
                new { id = brand.BrandId  },
                brand
                );
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBrand(int id , [FromBody] Brand updatedbrand)
        {
            if (updatedbrand == null || string.IsNullOrWhiteSpace(updatedbrand.BrandName))
            {
                return BadRequest("Brand is Required");
            }
            var existingbrand = await _context.Brands.FindAsync( id);
            if (existingbrand == null)
            {
                return NotFound("Brand not Found");
            }
            existingbrand.BrandName = updatedbrand.BrandName;
            await _context.SaveChangesAsync();
            return Ok($"Brand with {id} updated successfully");

        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBrand(int id )
        {
            var brand = await _context.Brands.FindAsync(id);
            if(brand == null)
            {
                return NotFound("Brand Not Found");
            }
            _context.Brands.Remove(brand);
            await _context.SaveChangesAsync();  
            return Ok($"Brand with {id} Deleted Successfully");

        }
    }
}
