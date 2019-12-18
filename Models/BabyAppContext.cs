using Microsoft.EntityFrameworkCore;

namespace BabyApp.Models
{
    public class BabyAppContext : DbContext
    {
        public DbSet<Nutritions> Nutritions { get; set; }
    }
}