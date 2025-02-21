using Microsoft.AspNetCore.Mvc;
using RMS.AddModels.AddEntities;
using RMS.Models.Entities;
using RMS.Models;
using Microsoft.EntityFrameworkCore;

namespace RMS.Controller
{

    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public CategoryController(ApplicationDbContext context)
        {
            this._context = context;
        }


        private static List<Category> Categories = new List<Category>();

        [HttpPost]
        public async Task<IActionResult> AddCategory([FromBody] AddCategory addcategory)
        {
            if (addcategory == null || string.IsNullOrWhiteSpace(addcategory.CategoryName))
            {
                return BadRequest("Category name is required.");
            }

            var category = new Category
            {
                CategoryName = addcategory.CategoryName
            };

            _context.Categories.Add(category);
            await _context.SaveChangesAsync();

            return CreatedAtRoute(
                "GetCategory",
                new { id = category.CategoryId },
                category);
        }


        [HttpGet("{id}", Name = "GetCategory")]
        public async Task<IActionResult> GetCategoryById(int id)
        {
            var category = await _context.Categories.FindAsync(id);

            if (category == null)
            {
                return NotFound();
            }

            return Ok(category);
        }
        [HttpGet]
        public async Task<IActionResult> GetAllCategories()
        {
            var categories = await _context.Categories.ToListAsync();

            if (categories == null || categories.Count == 0)
            {
                return NotFound("No categories found.");
            }

            return Ok(categories);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCategory(int id, [FromBody] Category updatedCategory)
        {
            if (updatedCategory == null || string.IsNullOrWhiteSpace(updatedCategory.CategoryName))
            {
                return BadRequest("Category name is required.");
            }

            var existingCategory = await _context.Categories.FindAsync(id);
            if (existingCategory == null)
            {
                return NotFound("Category not found.");
            }

            existingCategory.CategoryName = updatedCategory.CategoryName;
            await _context.SaveChangesAsync();

            return Ok($"Category with ID {id} updated successfully.");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            var category = await _context.Categories.FindAsync(id);

            if (category == null)
            {
                return NotFound("Category not found.");
            }

            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();

            return Ok($"Category with ID {id} deleted successfully.");
        }
    }
}

