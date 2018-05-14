using System;
using HomeIt.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace HomeIt.Db
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Gas> Gas { get; set; }
        public DbSet<Water> Water { get; set; }
        public DbSet<Electricity> Electricity { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Gas>().ToTable("Gas");
            modelBuilder.Entity<Water>().ToTable("Water");
            modelBuilder.Entity<Electricity>().ToTable("Electricity");
        }
    }
}
