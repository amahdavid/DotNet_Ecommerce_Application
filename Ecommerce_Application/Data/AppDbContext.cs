using Ecommerce_Application.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce_Application.Data
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            try
            {
                builder.Entity<Product>().HasData(
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Jordan 4 Military Black",
                        Price = 450,
                        Category = "Clothing",
                        Description = "These are slick fairly used Jordan 4's, size 11 US",
                        ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTOP5xeXw3UgSMynW5S5r9kBt1s2RwdFZwMTA&s"
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Apple iPhone 13",
                        Price = 799.99M,
                        Description = "Latest Apple iPhone 13, 128GB, Black",
                        Category = "Electronics",
                        ImageUrl = "https://www.svgrepo.com/show/508699/landscape-placeholder.svg"
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Sony WH-1000XM4 Headphones",
                        Price = 349.99M,
                        Description = "Wireless noise-canceling headphones",
                        Category = "Electronics",
                        ImageUrl = "https://www.svgrepo.com/show/508699/landscape-placeholder.svg"
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Samsung Galaxy S21",
                        Price = 699.99M,
                        Description = "Samsung Galaxy S21 128GB, Phantom Gray",
                        Category = "Electronics",
                        ImageUrl = "https://www.svgrepo.com/show/508699/landscape-placeholder.svg"
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Nike Air Max 270",
                        Price = 180,
                        Category = "Clothing",
                        Description = "Nike Air Max 270 shoes, size 10 US, in Black/White",
                        ImageUrl = "https://www.svgrepo.com/show/508699/landscape-placeholder.svg"
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Bose SoundLink Revolve",
                        Price = 199.99M,
                        Description = "Bose portable Bluetooth speaker, 360-degree sound",
                        Category = "Electronics",
                        ImageUrl = "https://www.svgrepo.com/show/508699/landscape-placeholder.svg"
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Adidas Ultraboost 21",
                        Price = 220,
                        Category = "Clothing",
                        Description = "Adidas Ultraboost 21 shoes, size 9 US, Solar Red",
                        ImageUrl = "https://www.svgrepo.com/show/508699/landscape-placeholder.svg"
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Apple MacBook Air M1",
                        Price = 999.99M,
                        Description = "Apple MacBook Air 13-inch, M1 chip, 256GB SSD",
                        Category = "Electronics",
                        ImageUrl = "https://www.svgrepo.com/show/508699/landscape-placeholder.svg"
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "North Face Men's Jacket",
                        Price = 250,
                        Category = "Clothing",
                        Description = "North Face men's winter jacket, size Large, Black",
                        ImageUrl = "https://www.svgrepo.com/show/508699/landscape-placeholder.svg"
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Sony PlayStation 5",
                        Price = 499.99M,
                        Description = "Sony PlayStation 5 console, 825GB, White",
                        Category = "Electronics",
                        ImageUrl = "https://www.svgrepo.com/show/508699/landscape-placeholder.svg"
                    }
                );
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error seeding data: " + ex.Message);
            }
            base.OnModelCreating(builder);
        }
    }
}