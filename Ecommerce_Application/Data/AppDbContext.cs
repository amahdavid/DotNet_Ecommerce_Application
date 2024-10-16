using Ecommerce_Application.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce_Application.Data
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

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
                        ImageUrl = "https://images.unsplash.com/photo-1675012321803-4a75a5d52229?w=500&auto=format&fit=crop&q=60&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MTl8fEFwcGxlJTIwaXBob25lJTIwMTN8ZW58MHx8MHx8fDA%3D"
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Sony WH-1000XM4 Headphones",
                        Price = 349.99M,
                        Description = "Wireless noise-canceling headphones",
                        Category = "Electronics",
                        ImageUrl = "https://i.rtings.com/assets/products/nggZcsC3/sony-wh-1000xm4-wireless/design-medium.jpg?format=auto"
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Samsung Galaxy S21",
                        Price = 699.99M,
                        Description = "Samsung Galaxy S21 128GB, Phantom Gray",
                        Category = "Electronics",
                        ImageUrl = "https://m.media-amazon.com/images/I/616kK0b+d+L._AC_UF894,1000_QL80_.jpg"
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Nike Air Max 270",
                        Price = 180,
                        Category = "Clothing",
                        Description = "Nike Air Max 270 shoes, size 10 US, in Black/White",
                        ImageUrl = "https://static.nike.com/a/images/t_PDP_936_v1/f_auto,q_auto:eco/rvdy0rcm3dea1on7uxpu/AIR+MAX+270.png"
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Bose SoundLink Revolve",
                        Price = 199.99M,
                        Description = "Bose portable Bluetooth speaker, 360-degree sound",
                        Category = "Electronics",
                        ImageUrl = "https://multimedia.bbycastatic.ca/multimedia/products/500x500/153/15341/15341688.jpg"
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Adidas Ultraboost 21",
                        Price = 220,
                        Category = "Clothing",
                        Description = "Adidas Ultraboost 21 shoes, size 9 US, Solar Red",
                        ImageUrl = "https://assets.adidas.com/images/h_840,f_auto,q_auto,fl_lossy,c_fill,g_auto/90176495b3364794bc7cad5100ba3f4d_9366/Ultraboost_21_GORE-TEX_Shoes_Green_FY3956_01_standard.jpg"
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Apple MacBook Air M1",
                        Price = 999.99M,
                        Description = "Apple MacBook Air 13-inch, M1 chip, 256GB SSD",
                        Category = "Electronics",
                        ImageUrl = "https://store.storeimages.cdn-apple.com/4982/as-images.apple.com/is/refurb-macbook-air-silver-m1-202010?wid=1144&hei=1144&fmt=jpeg&qlt=90&.v=1634145618000"
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "North Face Men's Jacket",
                        Price = 250,
                        Category = "Clothing",
                        Description = "North Face men's winter jacket, size Large, Black",
                        ImageUrl = "https://assets.thenorthface.com/images/t_img/c_pad,b_white,f_auto,h_650,w_555,e_sharpen:70/NF0A5GIEJK3-HERO/Mens-HydrenaliteTM-Down-Hoodie.png"
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Sony PlayStation 5",
                        Price = 499.99M,
                        Description = "Sony PlayStation 5 console, 825GB, White",
                        Category = "Electronics",
                        ImageUrl = "https://m.media-amazon.com/images/I/51CXJ8Rl7UL._AC_UF1000,1000_QL80_.jpg"
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