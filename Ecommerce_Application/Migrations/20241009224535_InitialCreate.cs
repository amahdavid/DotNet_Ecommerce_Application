using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ecommerce_Application.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerRegion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerPostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("0429e1bb-92d9-4cda-8877-d8980d342063"), "Electronics", "Sony PlayStation 5 console, 825GB, White", "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", "Sony PlayStation 5", 499.99m },
                    { new Guid("071694c9-a48e-494a-9969-c7c0fd743640"), "Clothing", "Adidas Ultraboost 21 shoes, size 9 US, Solar Red", "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", "Adidas Ultraboost 21", 220m },
                    { new Guid("187dd9e0-a3c1-4210-824f-2854f44c397c"), "Electronics", "Apple MacBook Air 13-inch, M1 chip, 256GB SSD", "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", "Apple MacBook Air M1", 999.99m },
                    { new Guid("66ad86d1-2f2e-401f-9b2d-986f55492c74"), "Clothing", "Nike Air Max 270 shoes, size 10 US, in Black/White", "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", "Nike Air Max 270", 180m },
                    { new Guid("7e38fb61-02ce-436c-a7e1-48abb52c13c7"), "Clothing", "North Face men's winter jacket, size Large, Black", "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", "North Face Men's Jacket", 250m },
                    { new Guid("85781b7c-3d5d-48b4-b7f2-acb7ec46ab28"), "Electronics", "Wireless noise-canceling headphones", "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", "Sony WH-1000XM4 Headphones", 349.99m },
                    { new Guid("d6bcc6a1-a736-41dc-a06a-a895ba4261ab"), "Electronics", "Samsung Galaxy S21 128GB, Phantom Gray", "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", "Samsung Galaxy S21", 699.99m },
                    { new Guid("e7ea0a46-b370-49b5-b785-ff4e8c4b11f5"), "Electronics", "Latest Apple iPhone 13, 128GB, Black", "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", "Apple iPhone 13", 799.99m },
                    { new Guid("f5577664-8a25-42a0-a895-6559a582980e"), "Clothing", "These are slick fairly used Jordan 4's, size 11 US", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTOP5xeXw3UgSMynW5S5r9kBt1s2RwdFZwMTA&s", "Jordan 4 Military Black", 450m },
                    { new Guid("fceb1cfb-7797-4896-a3c3-54a42c5c2f9a"), "Electronics", "Bose portable Bluetooth speaker, 360-degree sound", "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", "Bose SoundLink Revolve", 199.99m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}