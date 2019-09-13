using BazzarManagment.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BazzarManagment.DAL
{
    public class BazarContext : DbContext
    {
        public BazarContext(DbContextOptions<BazarContext> options)
            : base(options)

        {
        }
        public DbSet<Product> Poducts { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().Property(p => p.DateCreated)
            .HasDefaultValueSql("getdate()");
            modelBuilder.Entity<Product>().HasKey(k => k.Id).ForSqlServerIsClustered();
            base.OnModelCreating(modelBuilder);
        }
    }
}
