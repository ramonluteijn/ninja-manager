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
    }
}