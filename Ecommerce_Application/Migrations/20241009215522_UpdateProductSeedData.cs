using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ecommerce_Application.Migrations
{
    /// <inheritdoc />
    public partial class UpdateProductSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "These are slick fairly used Jordan 4's, size 11 US");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 4, "Electronics", "Samsung Galaxy S21 128GB, Phantom Gray", "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", "Samsung Galaxy S21", 699.99m },
                    { 5, "Clothing", "Nike Air Max 270 shoes, size 10 US, in Black/White", "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", "Nike Air Max 270", 180m },
                    { 6, "Electronics", "Bose portable Bluetooth speaker, 360-degree sound", "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", "Bose SoundLink Revolve", 199.99m },
                    { 7, "Clothing", "Adidas Ultraboost 21 shoes, size 9 US, Solar Red", "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", "Adidas Ultraboost 21", 220m },
                    { 8, "Electronics", "Apple MacBook Air 13-inch, M1 chip, 256GB SSD", "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", "Apple MacBook Air M1", 999.99m },
                    { 9, "Clothing", "North Face men's winter jacket, size Large, Black", "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", "North Face Men's Jacket", 250m },
                    { 10, "Electronics", "Sony PlayStation 5 console, 825GB, White", "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", "Sony PlayStation 5", 499.99m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "These are slick fairly used jordan 4's, size 11 US");
        }
    }
}
