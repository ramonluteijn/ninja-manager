using Microsoft.EntityFrameworkCore;
using ninjamanager.Models;

namespace ninjamanager.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ninjamanager.Models.Product> Products { get; set; } = default!;
        public DbSet<ninjamanager.Models.Category> Categories { get; set; } = default!;
        public DbSet<ninjamanager.Models.User> Users { get; set; } = default!;
    }
}