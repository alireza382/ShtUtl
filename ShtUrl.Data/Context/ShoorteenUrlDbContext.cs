using Microsoft.EntityFrameworkCore;
using ShtUrl.Domain.Models;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShtUrl.Data.Context
{
    public class ShoorteenUrlDbContext : DbContext
    {

        public ShoorteenUrlDbContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<ShorteenUrl> shorteenUrls { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
         
                
              
            base.OnModelCreating(modelBuilder);
        }
    }
}
