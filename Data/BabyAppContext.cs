using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
