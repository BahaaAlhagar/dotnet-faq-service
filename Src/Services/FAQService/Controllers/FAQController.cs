using FAQService.Data;
using FAQService.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FAQService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FAQController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public FAQController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<FAQModel>>> GetFAQs()
        {
            // Get all FAQs
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<FAQModel>> GetFAQ(int id)
        {
            // Get a specific FAQ by id
        }

        [HttpPost]
        public async Task<ActionResult<FAQModel>> CreateFAQ(FAQModel faq)
        {
            // Create a new FAQ
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateFAQ(int id, FAQModel faq)
        {
            // Update an existing FAQ
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFAQ(int id)
        {
            // Delete a specific FAQ by id
        }
    }
}