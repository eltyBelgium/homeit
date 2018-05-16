using System;
using HomeIt.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace HomeIt.Db
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Gas> Gas { get; set; }
        public DbSet<Water> Water { get; set; }
        public DbSet<Electricity> Electricity { get; set; }
        public DbSet<Errors> Errors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Gas>().ToTable("Gas");
            modelBuilder.Entity<Water>().ToTable("Water");
            modelBuilder.Entity<Electricity>().ToTable("Electricity");
            modelBuilder.Entity<Errors>().ToTable("Errors");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=blog.db");
        }
    }
}
