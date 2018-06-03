using API.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace API.DB
{
    public class DataContext : IdentityDbContext<AppUser>
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Gas> Gas { get; set; }
        public DbSet<Water> Water { get; set; }
        public DbSet<Electricity> Electricity { get; set; }
        public DbSet<Errors> Errors { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Gas>().ToTable("Gas");
            modelBuilder.Entity<Water>().ToTable("Water");
            modelBuilder.Entity<Electricity>().ToTable("Electricity");
            modelBuilder.Entity<Errors>().ToTable("Errors");
            modelBuilder.Entity<Customer>().ToTable("Customers");

            base.OnModelCreating(modelBuilder);
            modelBuilder.Ignore<IdentityUserLogin<string>>();
            modelBuilder.Ignore<IdentityUserRole<string>>();
            modelBuilder.Ignore<IdentityUserClaim<string>>();
            modelBuilder.Ignore<IdentityUserToken<string>>();
            modelBuilder.Ignore<IdentityUser<string>>();
            modelBuilder.Ignore<AppUser>();
        }

      
    }
}
