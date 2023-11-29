using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendProject.Migrations
{
    public partial class AddedProductCategoryProductImagesTableAndTheirSeededData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsMain = table.Column<bool>(type: "bit", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 16, 33, 15, 688, DateTimeKind.Local).AddTicks(7670));

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 16, 33, 15, 688, DateTimeKind.Local).AddTicks(7670));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "Name", "SoftDeleted" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 29, 16, 33, 15, 688, DateTimeKind.Local).AddTicks(7730), "Decorations", false },
                    { 2, new DateTime(2023, 11, 29, 16, 33, 15, 688, DateTimeKind.Local).AddTicks(7730), "Outfits", false },
                    { 3, new DateTime(2023, 11, 29, 16, 33, 15, 688, DateTimeKind.Local).AddTicks(7730), "Candles", false },
                    { 4, new DateTime(2023, 11, 29, 16, 33, 15, 688, DateTimeKind.Local).AddTicks(7730), "Toys", false }
                });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 16, 33, 15, 688, DateTimeKind.Local).AddTicks(7700));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 16, 33, 15, 688, DateTimeKind.Local).AddTicks(7710));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 16, 33, 15, 688, DateTimeKind.Local).AddTicks(7710));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 16, 33, 15, 688, DateTimeKind.Local).AddTicks(7690));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 16, 33, 15, 688, DateTimeKind.Local).AddTicks(7690));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 16, 33, 15, 688, DateTimeKind.Local).AddTicks(7690));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 16, 33, 15, 688, DateTimeKind.Local).AddTicks(7530));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 16, 33, 15, 688, DateTimeKind.Local).AddTicks(7570));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Description", "Name", "Price", "SoftDeleted" },
                values: new object[,]
                {
                    { 1, 3, new DateTime(2023, 11, 29, 16, 33, 15, 688, DateTimeKind.Local).AddTicks(7760), "Desc1", "Holiday Candle", 35m, false },
                    { 2, 1, new DateTime(2023, 11, 29, 16, 33, 15, 688, DateTimeKind.Local).AddTicks(7760), "Desc1", "Christmas Tree", 35m, false },
                    { 3, 4, new DateTime(2023, 11, 29, 16, 33, 15, 688, DateTimeKind.Local).AddTicks(7760), "Desc1", "Santa Claus Doll", 35m, false },
                    { 4, 2, new DateTime(2023, 11, 29, 16, 33, 15, 688, DateTimeKind.Local).AddTicks(7770), "Desc1", "Holiday Cap", 35m, false },
                    { 5, 4, new DateTime(2023, 11, 29, 16, 33, 15, 688, DateTimeKind.Local).AddTicks(7770), "Desc1", "Holiday Doll", 35m, false },
                    { 6, 3, new DateTime(2023, 11, 29, 16, 33, 15, 688, DateTimeKind.Local).AddTicks(7770), "Desc1", "Holiday Candle", 35m, false }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "CreatedDate", "Image", "IsMain", "ProductId", "SoftDeleted" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 29, 16, 33, 15, 688, DateTimeKind.Local).AddTicks(7790), "01.jpg", true, 1, false },
                    { 2, new DateTime(2023, 11, 29, 16, 33, 15, 688, DateTimeKind.Local).AddTicks(7790), "02.jpg", false, 1, false },
                    { 3, new DateTime(2023, 11, 29, 16, 33, 15, 688, DateTimeKind.Local).AddTicks(7790), "02.jpg", true, 2, false },
                    { 4, new DateTime(2023, 11, 29, 16, 33, 15, 688, DateTimeKind.Local).AddTicks(7800), "03.jpg", false, 2, false },
                    { 5, new DateTime(2023, 11, 29, 16, 33, 15, 688, DateTimeKind.Local).AddTicks(7800), "03.jpg", true, 3, false },
                    { 6, new DateTime(2023, 11, 29, 16, 33, 15, 688, DateTimeKind.Local).AddTicks(7800), "04.jpg", false, 3, false },
                    { 7, new DateTime(2023, 11, 29, 16, 33, 15, 688, DateTimeKind.Local).AddTicks(7800), "04.jpg", true, 4, false },
                    { 8, new DateTime(2023, 11, 29, 16, 33, 15, 688, DateTimeKind.Local).AddTicks(7810), "05.jpg", false, 4, false },
                    { 9, new DateTime(2023, 11, 29, 16, 33, 15, 688, DateTimeKind.Local).AddTicks(7810), "05.jpg", true, 5, false },
                    { 10, new DateTime(2023, 11, 29, 16, 33, 15, 688, DateTimeKind.Local).AddTicks(7810), "06.jpg", false, 5, false },
                    { 11, new DateTime(2023, 11, 29, 16, 33, 15, 688, DateTimeKind.Local).AddTicks(7820), "06.jpg", true, 6, false },
                    { 12, new DateTime(2023, 11, 29, 16, 33, 15, 688, DateTimeKind.Local).AddTicks(7820), "02.jpg", false, 6, false }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 16, 4, 49, 847, DateTimeKind.Local).AddTicks(8370));

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 16, 4, 49, 847, DateTimeKind.Local).AddTicks(8370));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 16, 4, 49, 847, DateTimeKind.Local).AddTicks(8410));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 16, 4, 49, 847, DateTimeKind.Local).AddTicks(8410));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 16, 4, 49, 847, DateTimeKind.Local).AddTicks(8410));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 16, 4, 49, 847, DateTimeKind.Local).AddTicks(8390));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 16, 4, 49, 847, DateTimeKind.Local).AddTicks(8390));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 16, 4, 49, 847, DateTimeKind.Local).AddTicks(8390));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 16, 4, 49, 847, DateTimeKind.Local).AddTicks(8240));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 16, 4, 49, 847, DateTimeKind.Local).AddTicks(8270));
        }
    }
}
