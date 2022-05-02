using DatabaseImageProject.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseImageProject.Models.Concrete
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=OZTURK;Database=ProductDbAksam;User=sa;Pwd=123;");
            }
        }
    }
}
