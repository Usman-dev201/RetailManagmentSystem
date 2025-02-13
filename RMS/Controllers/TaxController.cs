using Microsoft.AspNetCore.Mvc;
using RMS.Models;
using RMS.Models.Entities;

namespace RMS.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class TaxController : Controller
    {
        private readonly ApplicationDbContext _context;
        public TaxController(ApplicationDbContext context)
        { 
            _context = context;
        }
        private static List<Tax> taxes = new List<Tax>();

        [HttpPost]
        public async Task<ActionResult<Tax>> PostTax(Tax tax)
        {
            tax.EffectiveDate = DateTime.UtcNow; // Set current date and time

            _context.Taxes.Add(tax);
            await _context.SaveChangesAsync();

            return CreatedAtAction
                (nameof(PostTax), 
                new { id = tax.TaxId },
                tax);
        }

    }
}
