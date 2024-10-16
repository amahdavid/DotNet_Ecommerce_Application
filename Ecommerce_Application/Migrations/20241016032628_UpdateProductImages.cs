using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ecommerce_Application.Migrations
{
    /// <inheritdoc />
    public partial class UpdateProductImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "CustomerId",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("1c4142f9-4fd0-4aef-9363-a014b0d75327"), "Clothing", "Adidas Ultraboost 21 shoes, size 9 US, Solar Red", "https://assets.adidas.com/images/h_840,f_auto,q_auto,fl_lossy,c_fill,g_auto/90176495b3364794bc7cad5100ba3f4d_9366/Ultraboost_21_GORE-TEX_Shoes_Green_FY3956_01_standard.jpg", "Adidas Ultraboost 21", 220m },
                    { new Guid("20d890f6-ce5e-45be-a473-d7e702e4f386"), "Electronics", "Samsung Galaxy S21 128GB, Phantom Gray", "https://m.media-amazon.com/images/I/616kK0b+d+L._AC_UF894,1000_QL80_.jpg", "Samsung Galaxy S21", 699.99m },
                    { new Guid("24f1edb3-9ceb-4345-85c3-7f65243c04b0"), "Electronics", "Apple MacBook Air 13-inch, M1 chip, 256GB SSD", "https://store.storeimages.cdn-apple.com/4982/as-images.apple.com/is/refurb-macbook-air-silver-m1-202010?wid=1144&hei=1144&fmt=jpeg&qlt=90&.v=1634145618000", "Apple MacBook Air M1", 999.99m },
                    { new Guid("40159cb2-e4bd-4974-be47-f81f4943cabc"), "Electronics", "Sony PlayStation 5 console, 825GB, White", "https://m.media-amazon.com/images/I/51CXJ8Rl7UL._AC_UF1000,1000_QL80_.jpg", "Sony PlayStation 5", 499.99m },
                    { new Guid("59991f4f-5dff-4283-80cc-ca3a789f1efd"), "Electronics", "Bose portable Bluetooth speaker, 360-degree sound", "https://multimedia.bbycastatic.ca/multimedia/products/500x500/153/15341/15341688.jpg", "Bose SoundLink Revolve", 199.99m },
                    { new Guid("6ba36b36-1804-4c50-a5b8-853f2609f759"), "Electronics", "Wireless noise-canceling headphones", "https://i.rtings.com/assets/products/nggZcsC3/sony-wh-1000xm4-wireless/design-medium.jpg?format=auto", "Sony WH-1000XM4 Headphones", 349.99m },
                    { new Guid("9116564b-48cb-4e05-8b85-4ea19be503e8"), "Clothing", "These are slick fairly used Jordan 4's, size 11 US", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTOP5xeXw3UgSMynW5S5r9kBt1s2RwdFZwMTA&s", "Jordan 4 Military Black", 450m },
                    { new Guid("989dfc92-6a22-46a6-a9c6-52fa4e1b2bd9"), "Clothing", "Nike Air Max 270 shoes, size 10 US, in Black/White", "https://static.nike.com/a/images/t_PDP_936_v1/f_auto,q_auto:eco/rvdy0rcm3dea1on7uxpu/AIR+MAX+270.png", "Nike Air Max 270", 180m },
                    { new Guid("9f8be224-44a4-448d-a2f1-feb8d297e809"), "Electronics", "Latest Apple iPhone 13, 128GB, Black", "https://images.unsplash.com/photo-1675012321803-4a75a5d52229?w=500&auto=format&fit=crop&q=60&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MTl8fEFwcGxlJTIwaXBob25lJTIwMTN8ZW58MHx8MHx8fDA%3D", "Apple iPhone 13", 799.99m },
                    { new Guid("f4382a17-4dae-4f76-96fc-82bb6788ca3d"), "Clothing", "North Face men's winter jacket, size Large, Black", "https://assets.thenorthface.com/images/t_img/c_pad,b_white,f_auto,h_650,w_555,e_sharpen:70/NF0A5GIEJK3-HERO/Mens-HydrenaliteTM-Down-Hoodie.png", "North Face Men's Jacket", 250m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1c4142f9-4fd0-4aef-9363-a014b0d75327"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("20d890f6-ce5e-45be-a473-d7e702e4f386"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("24f1edb3-9ceb-4345-85c3-7f65243c04b0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("40159cb2-e4bd-4974-be47-f81f4943cabc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("59991f4f-5dff-4283-80cc-ca3a789f1efd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6ba36b36-1804-4c50-a5b8-853f2609f759"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9116564b-48cb-4e05-8b85-4ea19be503e8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("989dfc92-6a22-46a6-a9c6-52fa4e1b2bd9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9f8be224-44a4-448d-a2f1-feb8d297e809"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f4382a17-4dae-4f76-96fc-82bb6788ca3d"));

            migrationBuilder.AlterColumn<Guid>(
                name: "CustomerId",
                table: "Orders",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
    }
}
