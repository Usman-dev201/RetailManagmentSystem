using Microsoft.AspNetCore.Mvc;
using RMS.Models;
using RMS.Models.Entities;

namespace RMS.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class CategoryController : Controller
    {
       private readonly ApplicationDbContext _context;
        public CategoryController(ApplicationDbContext context)
        {
            _context = context;
        }
        private static List<AddBrand> brands = new List<AddBrand>();

        [HttpPost]
        public async Task<ActionResult<AddCategory>> PostCategory(AddCategory category)
        {
            _context.Categories.Add(category);
            await _context.SaveChangesAsync();

            return CreatedAtAction
                (nameof(PostCategory),
                new { id = category.CategoryId },
                category);
        }

    }
}
