using FAQService.Models;
using Microsoft.EntityFrameworkCore;

namespace FAQService.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<FAQModel> FAQs { get; set; } // Renamed the property to FAQs
    }
}