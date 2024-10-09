using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ecommerce_Application.Migrations
{
    /// <inheritdoc />
    public partial class UpdateOrderSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0429e1bb-92d9-4cda-8877-d8980d342063"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("071694c9-a48e-494a-9969-c7c0fd743640"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("187dd9e0-a3c1-4210-824f-2854f44c397c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("66ad86d1-2f2e-401f-9b2d-986f55492c74"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7e38fb61-02ce-436c-a7e1-48abb52c13c7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("85781b7c-3d5d-48b4-b7f2-acb7ec46ab28"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d6bcc6a1-a736-41dc-a06a-a895ba4261ab"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e7ea0a46-b370-49b5-b785-ff4e8c4b11f5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f5577664-8a25-42a0-a895-6559a582980e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fceb1cfb-7797-4896-a3c3-54a42c5c2f9a"));

            migrationBuilder.RenameColumn(
                name: "CustomerRegion",
                table: "Orders",
                newName: "Region");

            migrationBuilder.RenameColumn(
                name: "CustomerPostalCode",
                table: "Orders",
                newName: "PostalCode");

            migrationBuilder.RenameColumn(
                name: "CustomerPhone",
                table: "Orders",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "CustomerName",
                table: "Orders",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "CustomerEmail",
                table: "Orders",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "CustomerCity",
                table: "Orders",
                newName: "City");

            migrationBuilder.AlterColumn<Guid>(
                name: "CustomerId",
                table: "Orders",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<decimal>(
                name: "TotalAmount",
                table: "Orders",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "OrderItem",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItem_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id");
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_OrderId",
                table: "OrderItem",
                column: "OrderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderItem");

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

            migrationBuilder.DropColumn(
                name: "OrderDate",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "TotalAmount",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "Region",
                table: "Orders",
                newName: "CustomerRegion");

            migrationBuilder.RenameColumn(
                name: "PostalCode",
                table: "Orders",
                newName: "CustomerPostalCode");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Orders",
                newName: "CustomerPhone");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Orders",
                newName: "CustomerName");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Orders",
                newName: "CustomerEmail");

            migrationBuilder.RenameColumn(
                name: "City",
                table: "Orders",
                newName: "CustomerCity");

            migrationBuilder.AlterColumn<string>(
                name: "CustomerId",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

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
    }
}
