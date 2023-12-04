using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendProject.Migrations
{
    public partial class addedCartWishlistModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Carts_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Wishlists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wishlists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Wishlists_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CartProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Count = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CartId = table.Column<int>(type: "int", nullable: false),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartProducts_Carts_CartId",
                        column: x => x.CartId,
                        principalTable: "Carts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WishlistProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    WishlistId = table.Column<int>(type: "int", nullable: false),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WishlistProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WishlistProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WishlistProducts_Wishlists_WishlistId",
                        column: x => x.WishlistId,
                        principalTable: "Wishlists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(3950));

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(3490));

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(3490));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(3800));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(3800));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(3800));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(3810));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(3810));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(3810));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(3820));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(3820));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(3820));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(3820));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(3820));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(3830));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(3830));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(3830));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(3830));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(3840));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(3840));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(3840));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(3840));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(3850));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(3850));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(3850));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(3850));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(3860));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(3990));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(3990));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(3990));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(3990));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(4000));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(4000));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(3560));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(3570));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(3570));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(3570));

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(4040));

            migrationBuilder.UpdateData(
                table: "ContactMessages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(4050));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(3540));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(3540));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(3540));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(3550));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(3550));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(3650));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(3650));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(3650));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(3660));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(3660));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(3660));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(3660));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(3670));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(3670));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(3670));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(3670));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(3680));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(3590));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(3590));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(3620));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(3620));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(3630));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(3630));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(3510));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(3510));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(3510));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(3520));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(3520));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(3520));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(3700));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(3700));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(3700));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(3700));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(3710));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(3710));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(3330));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(3370));

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(4010));

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(4020));

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(4020));

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(4020));

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(4020));

            migrationBuilder.UpdateData(
                table: "Subscribes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(3930));

            migrationBuilder.UpdateData(
                table: "Subscribes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(3930));

            migrationBuilder.UpdateData(
                table: "Subscribes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(3930));

            migrationBuilder.UpdateData(
                table: "Subscribes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(3930));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(3730));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(3730));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(3730));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(3740));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(3740));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(3740));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(3740));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(3960));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(3970));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(3970));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 16, 0, 28, 420, DateTimeKind.Local).AddTicks(3970));

            migrationBuilder.CreateIndex(
                name: "IX_CartProducts_CartId",
                table: "CartProducts",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_CartProducts_ProductId",
                table: "CartProducts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_AppUserId",
                table: "Carts",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_WishlistProducts_ProductId",
                table: "WishlistProducts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_WishlistProducts_WishlistId",
                table: "WishlistProducts",
                column: "WishlistId");

            migrationBuilder.CreateIndex(
                name: "IX_Wishlists_AppUserId",
                table: "Wishlists",
                column: "AppUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartProducts");

            migrationBuilder.DropTable(
                name: "WishlistProducts");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Wishlists");

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7650));

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7190));

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7190));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7490));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7500));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7500));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7500));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7500));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7510));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7510));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7510));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7520));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7520));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7520));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7520));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7530));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7530));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7530));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7530));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7540));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7540));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7540));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7550));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7550));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7550));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7550));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7560));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7690));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7690));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7690));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7690));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7720));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7720));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7270));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7270));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7270));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7280));

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7760));

            migrationBuilder.UpdateData(
                table: "ContactMessages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7780));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7240));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7240));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7250));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7250));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7250));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7330));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7340));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7340));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7340));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7340));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7350));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7350));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7350));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7350));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7360));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7360));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7360));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7290));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7300));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7310));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7310));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7310));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7320));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7210));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7210));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7220));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7220));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7220));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7220));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7380));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7380));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7390));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7390));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7390));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7400));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7060));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7080));

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7740));

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7740));

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7750));

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7750));

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7750));

            migrationBuilder.UpdateData(
                table: "Subscribes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7630));

            migrationBuilder.UpdateData(
                table: "Subscribes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7630));

            migrationBuilder.UpdateData(
                table: "Subscribes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7630));

            migrationBuilder.UpdateData(
                table: "Subscribes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7630));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7410));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7420));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7420));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7420));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7420));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7430));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7430));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7660));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7670));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7670));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 9, 36, 13, 352, DateTimeKind.Local).AddTicks(7670));
        }
    }
}
