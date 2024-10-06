using Ecommerce_Application.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce_Application.Data
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Jordan 4 Military Black",
                    Price = 450,
                    Category = "Clothing",
                    Description = "These are slick fairly used jordan 4's, size 11 US",
                    ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTOP5xeXw3UgSMynW5S5r9kBt1s2RwdFZwMTA&s"
                },
                new Product 
                { 
                    Id = 2, 
                    Name = "Apple iPhone 13", 
                    Price = 799.99M, Description = "Latest Apple iPhone 13, 128GB, Black", 
                    Category = "Electronics", 
                    ImageUrl = "https://www.svgrepo.com/show/508699/landscape-placeholder.svg"
                },
                new Product 
                { 
                    Id = 3, 
                    Name = "Sony WH-1000XM4 Headphones", 
                    Price = 349.99M, 
                    Description = "Wireless noise-canceling headphones", 
                    Category = "Electronics", 
                    ImageUrl = "https://www.svgrepo.com/show/508699/landscape-placeholder.svg"
                }
                );
            base.OnModelCreating(builder);
        }
    }
}
