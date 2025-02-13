using Microsoft.AspNetCore.Mvc;
using RMS.Models;
using RMS.Models.Entities;

namespace RMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class DiscountController : Controller
    {
      private readonly ApplicationDbContext _context;
        public DiscountController(ApplicationDbContext context)
        {
            _context = context;
        }
        private static List<Discount> discounts = new List<Discount>();

        [HttpPost]
        public async Task<ActionResult<Discount>> PostDiscount(Discount discount)
        {
            discount.ValidFrom = DateTime.UtcNow; // Set current date and time

            _context.Discounts.Add(discount);
            await _context.SaveChangesAsync();

            return CreatedAtAction
                (nameof(PostDiscount),
                new { id = discount.DiscountId }, 
                discount);
        }
    }
}
