using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendProject.Migrations
{
    public partial class AddedCustomerAndReviewTableAndTheirSeededData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 15, 19, 18, 550, DateTimeKind.Local).AddTicks(2690));

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 15, 19, 18, 550, DateTimeKind.Local).AddTicks(2700));

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedDate", "FullName", "Image", "SoftDeleted" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 29, 15, 19, 18, 550, DateTimeKind.Local).AddTicks(2730), "Betty More", "1.jpg", false },
                    { 2, new DateTime(2023, 11, 29, 15, 19, 18, 550, DateTimeKind.Local).AddTicks(2730), "Andy Morgan", "1.jpg", false },
                    { 3, new DateTime(2023, 11, 29, 15, 19, 18, 550, DateTimeKind.Local).AddTicks(2740), "Sandra Black", "1.jpg", false }
                });

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 15, 19, 18, 550, DateTimeKind.Local).AddTicks(2540));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 15, 19, 18, 550, DateTimeKind.Local).AddTicks(2590));

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Message", "SoftDeleted" },
                values: new object[] { 1, new DateTime(2023, 11, 29, 15, 19, 18, 550, DateTimeKind.Local).AddTicks(2710), 1, "But I must explain to you how all this mistaken idea of denouncing pleasure and praising pain was born and I will give you a complete account of the system.", false });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Message", "SoftDeleted" },
                values: new object[] { 2, new DateTime(2023, 11, 29, 15, 19, 18, 550, DateTimeKind.Local).AddTicks(2710), 2, "I absolutely loved this product! It exceeded my expectations in every way. The quality is outstanding, and it arrived sooner than expected.", false });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Message", "SoftDeleted" },
                values: new object[] { 3, new DateTime(2023, 11, 29, 15, 19, 18, 550, DateTimeKind.Local).AddTicks(2720), 3, "Unfortunately, this item did not meet my expectations. The quality was subpar, and it didn't function as described. I'm quite disappointed with my purchase.", false });

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_CustomerId",
                table: "Reviews",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 13, 18, 14, 75, DateTimeKind.Local).AddTicks(7190));

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 13, 18, 14, 75, DateTimeKind.Local).AddTicks(7190));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 13, 18, 14, 75, DateTimeKind.Local).AddTicks(7060));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 13, 18, 14, 75, DateTimeKind.Local).AddTicks(7090));
        }
    }
}
