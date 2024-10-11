using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ecommerce_Application.Migrations
{
    /// <inheritdoc />
    public partial class AddUserSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1dec053f-d6a6-4453-8515-81cea7364d83"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("257bdf28-c37a-475a-b3bc-f2aa114d6a73"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3585b57e-e03b-4299-943a-b1e33634eb1f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("55385e9c-1bc0-412d-b664-59eeb195f756"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("65f2573a-1922-43c8-9fb3-d73b09f066fc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("66db6a71-84a3-4e6d-b8c2-5613fcc9ae36"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8fad2c93-91e0-4d0c-9ae7-57feef9fe4fa"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9569e5ab-7711-4fa6-aac8-930d1cfd1ceb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("de6465b3-41d0-4418-8d0d-4f5634981e1f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("eb6bd408-0f22-401e-81fc-cfcd30bc6926"));

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegisteredDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("256aa01d-1235-404e-843f-9d67150e8780"), "Clothing", "Adidas Ultraboost 21 shoes, size 9 US, Solar Red", "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", "Adidas Ultraboost 21", 220m },
                    { new Guid("39fbade4-54a7-482b-b202-87fc3e060021"), "Electronics", "Apple MacBook Air 13-inch, M1 chip, 256GB SSD", "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", "Apple MacBook Air M1", 999.99m },
                    { new Guid("741a934b-4b1a-43b1-bdbb-b96a20798a87"), "Electronics", "Samsung Galaxy S21 128GB, Phantom Gray", "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", "Samsung Galaxy S21", 699.99m },
                    { new Guid("7c8fdea1-1858-43b7-8663-7a6aadf63148"), "Electronics", "Bose portable Bluetooth speaker, 360-degree sound", "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", "Bose SoundLink Revolve", 199.99m },
                    { new Guid("a4b3b275-cb9b-41ce-becf-82f08479f018"), "Electronics", "Sony PlayStation 5 console, 825GB, White", "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", "Sony PlayStation 5", 499.99m },
                    { new Guid("b042a5e4-8619-4328-bd80-9fb0d741b843"), "Clothing", "Nike Air Max 270 shoes, size 10 US, in Black/White", "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", "Nike Air Max 270", 180m },
                    { new Guid("d11dc21f-39a2-4ef4-879c-3db074c5cf21"), "Clothing", "These are slick fairly used Jordan 4's, size 11 US", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTOP5xeXw3UgSMynW5S5r9kBt1s2RwdFZwMTA&s", "Jordan 4 Military Black", 450m },
                    { new Guid("e457d006-98a6-4bd9-893e-8ed0a7660a75"), "Electronics", "Latest Apple iPhone 13, 128GB, Black", "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", "Apple iPhone 13", 799.99m },
                    { new Guid("eff69b95-10d4-4984-8288-8296ec9eea12"), "Clothing", "North Face men's winter jacket, size Large, Black", "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", "North Face Men's Jacket", 250m },
                    { new Guid("f487c5c2-5055-4319-90ae-026852f9d059"), "Electronics", "Wireless noise-canceling headphones", "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", "Sony WH-1000XM4 Headphones", 349.99m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("256aa01d-1235-404e-843f-9d67150e8780"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("39fbade4-54a7-482b-b202-87fc3e060021"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("741a934b-4b1a-43b1-bdbb-b96a20798a87"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7c8fdea1-1858-43b7-8663-7a6aadf63148"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a4b3b275-cb9b-41ce-becf-82f08479f018"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b042a5e4-8619-4328-bd80-9fb0d741b843"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d11dc21f-39a2-4ef4-879c-3db074c5cf21"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e457d006-98a6-4bd9-893e-8ed0a7660a75"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("eff69b95-10d4-4984-8288-8296ec9eea12"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f487c5c2-5055-4319-90ae-026852f9d059"));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("1dec053f-d6a6-4453-8515-81cea7364d83"), "Electronics", "Sony PlayStation 5 console, 825GB, White", "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", "Sony PlayStation 5", 499.99m },
                    { new Guid("257bdf28-c37a-475a-b3bc-f2aa114d6a73"), "Clothing", "Adidas Ultraboost 21 shoes, size 9 US, Solar Red", "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", "Adidas Ultraboost 21", 220m },
                    { new Guid("3585b57e-e03b-4299-943a-b1e33634eb1f"), "Clothing", "These are slick fairly used Jordan 4's, size 11 US", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTOP5xeXw3UgSMynW5S5r9kBt1s2RwdFZwMTA&s", "Jordan 4 Military Black", 450m },
                    { new Guid("55385e9c-1bc0-412d-b664-59eeb195f756"), "Electronics", "Latest Apple iPhone 13, 128GB, Black", "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", "Apple iPhone 13", 799.99m },
                    { new Guid("65f2573a-1922-43c8-9fb3-d73b09f066fc"), "Electronics", "Apple MacBook Air 13-inch, M1 chip, 256GB SSD", "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", "Apple MacBook Air M1", 999.99m },
                    { new Guid("66db6a71-84a3-4e6d-b8c2-5613fcc9ae36"), "Electronics", "Wireless noise-canceling headphones", "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", "Sony WH-1000XM4 Headphones", 349.99m },
                    { new Guid("8fad2c93-91e0-4d0c-9ae7-57feef9fe4fa"), "Electronics", "Samsung Galaxy S21 128GB, Phantom Gray", "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", "Samsung Galaxy S21", 699.99m },
                    { new Guid("9569e5ab-7711-4fa6-aac8-930d1cfd1ceb"), "Electronics", "Bose portable Bluetooth speaker, 360-degree sound", "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", "Bose SoundLink Revolve", 199.99m },
                    { new Guid("de6465b3-41d0-4418-8d0d-4f5634981e1f"), "Clothing", "North Face men's winter jacket, size Large, Black", "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", "North Face Men's Jacket", 250m },
                    { new Guid("eb6bd408-0f22-401e-81fc-cfcd30bc6926"), "Clothing", "Nike Air Max 270 shoes, size 10 US, in Black/White", "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", "Nike Air Max 270", 180m }
                });
        }
    }
}
