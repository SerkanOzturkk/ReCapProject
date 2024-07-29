using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class CarDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=CarDb;Trusted_Connection=True");
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    // User entity configuration
        //    modelBuilder.Entity<User>().HasKey(u => u.Id);
        //    modelBuilder.Entity<User>()
        //        .HasMany(u => u.Customers)
        //        .WithOne(c => c.User)
        //        .HasForeignKey(c => c.UserId);

        //    // Customer entity configuration
        //    modelBuilder.Entity<Customer>().HasKey(c => c.UserId);

        //    // Car entity configuration
        //    modelBuilder.Entity<Car>().HasKey(c => c.CarId);

        //    // Brand entity configuration
        //    modelBuilder.Entity<Brand>().HasKey(b => b.BrandId);

        //    // Color entity configuration
        //    modelBuilder.Entity<Color>().HasKey(cl => cl.ColorId);

        //    // Rental entity configuration
        //    modelBuilder.Entity<Rental>().HasKey(r => r.Id);
        //    modelBuilder.Entity<Rental>()
        //        .HasOne(r => r.Car)
        //        .WithMany()
        //        .HasForeignKey(r => r.CarId);

        //    modelBuilder.Entity<Rental>()
        //        .HasOne(r => r.Customer)
        //        .WithMany()
        //        .HasForeignKey(r => r.CustomerId);
        //}

        public DbSet<Car> Cars { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers{ get; set; }
        public DbSet<Rental> Rentals { get; set; }
        
    }
}
