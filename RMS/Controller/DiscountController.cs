using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RMS.AddModels.AddEntities;
using RMS.Models;
using RMS.Models.Entities;

namespace RMS.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class DiscountController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public DiscountController(ApplicationDbContext context)
        {
            _context = context;
        }
       private static List<Discount> Discounts = new List<Discount>();
        [HttpGet]
        public async Task<IActionResult> GetAllDiscounts()
        {
            var discount = await _context.Discounts.ToListAsync();
            if (discount == null || discount.Count == 0)
            {
                return NotFound("Discount not Found");
            }
            return Ok(discount);
        }
        [HttpGet("{id}", Name = "GetDiscount")]
        public async Task<IActionResult> GetDiscountbyId(int id)
        {
            var discount = await _context.Discounts.FindAsync(id);
            if (discount == null)
            {
                return NotFound();
            }
            return Ok(discount);

        }
        [HttpPost]
        public async Task<IActionResult> AddDiscount([FromBody] RMS.AddModels.AddEntities.AddDiscount addDiscount)
        {
           
            var discount = new Discount
            {
                DiscountCode = addDiscount.DiscountCode,
                DiscountType = addDiscount.DiscountType,
                DiscountAmount = addDiscount.DiscountAmount,
                ValidFrom = addDiscount.ValidFrom,
                ValidUntil = addDiscount.ValidUntil,
                MinimumPurchaseAmount = addDiscount.MinimumPurchaseAmount,
                MaxDiscountLimit = addDiscount.MaxDiscountLimit,
                Status = addDiscount.Status
            };

            _context.Discounts.Add(discount);
            await _context.SaveChangesAsync();
            return CreatedAtRoute(
                "GetDiscount",
                new { id = discount.DiscountId },
                discount
            );
        }
        [HttpDelete ("{id}")]
        public async Task<IActionResult> DeleteDiscount(int id)
        {
            var discount = await _context.Discounts.FindAsync(id);
            if(discount == null)
            {
                return NotFound("Discount not Found");
            }
            _context.Discounts.Remove(discount);
            await _context.SaveChangesAsync();
            return Ok($"Discount with {id} deleted successfully");
        }
        [HttpPut ("{id}")]
        public async Task<IActionResult> UpdateDiscount(int id , [FromBody] Discount updatedDiscount)
        {
            var existingdiscount = await _context.Discounts.FindAsync(id);
            if (existingdiscount == null)
            {
                return NotFound("Discount not Found");
            }
            existingdiscount.DiscountCode = updatedDiscount.DiscountCode;
            existingdiscount.DiscountType = updatedDiscount.DiscountType;
            existingdiscount.DiscountAmount = updatedDiscount.DiscountAmount;
            existingdiscount.ValidUntil = updatedDiscount.ValidUntil;
            existingdiscount.MinimumPurchaseAmount = updatedDiscount.MinimumPurchaseAmount;
            existingdiscount.MaxDiscountLimit = updatedDiscount.MaxDiscountLimit;
            existingdiscount.Status = updatedDiscount.Status;

            await _context.SaveChangesAsync();
            return Ok($"Discount with {id} updated Successfully");
            
            
        }

    }
}
