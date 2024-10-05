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
                }
                );
            base.OnModelCreating(builder);
        }
    }
}
