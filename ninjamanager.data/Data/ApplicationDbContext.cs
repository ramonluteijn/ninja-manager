using Microsoft.EntityFrameworkCore;
using ninjamanager.data.Models;

namespace ninjamanager.data.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Product> Products { get; set; } = default!;
        public DbSet<Category> Categories { get; set; } = default!;
        public DbSet<User> Users { get; set; } = default!;
    }
}