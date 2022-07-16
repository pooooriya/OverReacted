using Microsoft.EntityFrameworkCore;
using OverReacted.Domain.Entities;
using OverReacted.Infrastructure.Persistance.SeedData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverReacted.Infrastructure.Persistance
{
    public class OverReactedDbContext:DbContext
    {
        public OverReactedDbContext(DbContextOptions dbContextOptions):base(dbContextOptions)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Article> Articles { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new OverReactedSeedData(modelBuilder).Seed();
            base.OnModelCreating(modelBuilder); 
        }
    }
}
