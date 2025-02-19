using Microsoft.AspNetCore.Mvc;
using RMS.Models;
using RMS.Models.Entities;

namespace RMS.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class LocationController : Controller
    {
       private readonly ApplicationDbContext _context;
        public LocationController(ApplicationDbContext context) { 
            _context = context;
        }
        private static List<Location> locations = new List<Location>();

        [HttpPost]
        public async Task<ActionResult<Location>> PostLocation(Location location)
        {
            _context.Locations.Add(location);
            await _context.SaveChangesAsync();

            return CreatedAtAction(
                nameof(PostLocation), 
                new { id = location.LocationId }, 
                location);
        }
    }
}
