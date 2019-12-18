using Microsoft.EntityFrameworkCore;
using BabyApp.Models;

namespace BabyApp.Data
{
    public class BabyAppContext : DbContext
    {
        public BabyAppContext (DbContextOptions<BabyAppContext> options)
            : base(options)
        {
        }

        public DbSet<BabyApp.Models.Nutritions> Nutritions { get; set; }
    }
}
