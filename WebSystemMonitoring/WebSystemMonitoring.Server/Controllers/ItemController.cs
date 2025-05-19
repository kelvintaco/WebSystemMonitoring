using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebSystemMonitoring.Server.Data;
using WebSystemMonitoring.Server.Models;
using System.Threading.Tasks;

namespace WebSystemMonitoring.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ItemController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<ItemController> _logger;

        public ItemController(ApplicationDbContext context, ILogger<ItemController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpDelete("byDescription/{description}")]
        public async Task<IActionResult> DeleteByDescription(string description)
        {
            try
            {
                _logger.LogInformation("Attempting to delete item with description: {Description}", description);

                // Find the item by description
                var item = await _context.Items
                    .FirstOrDefaultAsync(i => i.ItemDescription == description);

                if (item == null)
                {
                    _logger.LogWarning("No item found with description: {Description}", description);
                    return NotFound($"No item found with description: {description}");
                }

                // Remove the item
                _context.Items.Remove(item);
                await _context.SaveChangesAsync();

                _logger.LogInformation("Successfully deleted item with description: {Description}", description);
                return Ok($"Item with description {description} has been deleted");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error deleting item with description: {Description}", description);
                return StatusCode(500, "An error occurred while deleting the item");
            }
        }

        // Keep existing endpoints...
    }
} 