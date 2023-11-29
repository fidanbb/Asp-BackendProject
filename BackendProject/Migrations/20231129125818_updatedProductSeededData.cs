using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendProject.Migrations
{
    public partial class updatedProductSeededData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 16, 58, 18, 109, DateTimeKind.Local).AddTicks(6060));

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 16, 58, 18, 109, DateTimeKind.Local).AddTicks(6060));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 16, 58, 18, 109, DateTimeKind.Local).AddTicks(6120));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 16, 58, 18, 109, DateTimeKind.Local).AddTicks(6120));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 16, 58, 18, 109, DateTimeKind.Local).AddTicks(6120));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 16, 58, 18, 109, DateTimeKind.Local).AddTicks(6120));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 16, 58, 18, 109, DateTimeKind.Local).AddTicks(6090));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 16, 58, 18, 109, DateTimeKind.Local).AddTicks(6100));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 16, 58, 18, 109, DateTimeKind.Local).AddTicks(6100));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Image" },
                values: new object[] { new DateTime(2023, 11, 29, 16, 58, 18, 109, DateTimeKind.Local).AddTicks(6170), "1.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Image" },
                values: new object[] { new DateTime(2023, 11, 29, 16, 58, 18, 109, DateTimeKind.Local).AddTicks(6170), "2.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Image" },
                values: new object[] { new DateTime(2023, 11, 29, 16, 58, 18, 109, DateTimeKind.Local).AddTicks(6180), "2.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Image" },
                values: new object[] { new DateTime(2023, 11, 29, 16, 58, 18, 109, DateTimeKind.Local).AddTicks(6180), "3.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Image" },
                values: new object[] { new DateTime(2023, 11, 29, 16, 58, 18, 109, DateTimeKind.Local).AddTicks(6180), "3.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Image" },
                values: new object[] { new DateTime(2023, 11, 29, 16, 58, 18, 109, DateTimeKind.Local).AddTicks(6180), "4.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Image" },
                values: new object[] { new DateTime(2023, 11, 29, 16, 58, 18, 109, DateTimeKind.Local).AddTicks(6190), "4.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Image" },
                values: new object[] { new DateTime(2023, 11, 29, 16, 58, 18, 109, DateTimeKind.Local).AddTicks(6190), "5.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Image" },
                values: new object[] { new DateTime(2023, 11, 29, 16, 58, 18, 109, DateTimeKind.Local).AddTicks(6190), "5.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Image" },
                values: new object[] { new DateTime(2023, 11, 29, 16, 58, 18, 109, DateTimeKind.Local).AddTicks(6190), "6.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Image" },
                values: new object[] { new DateTime(2023, 11, 29, 16, 58, 18, 109, DateTimeKind.Local).AddTicks(6200), "6.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Image" },
                values: new object[] { new DateTime(2023, 11, 29, 16, 58, 18, 109, DateTimeKind.Local).AddTicks(6200), "2.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 16, 58, 18, 109, DateTimeKind.Local).AddTicks(6140));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2023, 11, 29, 16, 58, 18, 109, DateTimeKind.Local).AddTicks(6140), 40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2023, 11, 29, 16, 58, 18, 109, DateTimeKind.Local).AddTicks(6150), 30m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2023, 11, 29, 16, 58, 18, 109, DateTimeKind.Local).AddTicks(6150), 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2023, 11, 29, 16, 58, 18, 109, DateTimeKind.Local).AddTicks(6150), 60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2023, 11, 29, 16, 58, 18, 109, DateTimeKind.Local).AddTicks(6150), 30m });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 16, 58, 18, 109, DateTimeKind.Local).AddTicks(6070));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 16, 58, 18, 109, DateTimeKind.Local).AddTicks(6080));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 16, 58, 18, 109, DateTimeKind.Local).AddTicks(6080));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 16, 58, 18, 109, DateTimeKind.Local).AddTicks(5940));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 16, 58, 18, 109, DateTimeKind.Local).AddTicks(5950));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 16, 33, 15, 688, DateTimeKind.Local).AddTicks(7730));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 16, 33, 15, 688, DateTimeKind.Local).AddTicks(7730));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 16, 33, 15, 688, DateTimeKind.Local).AddTicks(7730));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 16, 33, 15, 688, DateTimeKind.Local).AddTicks(7730));

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
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Image" },
                values: new object[] { new DateTime(2023, 11, 29, 16, 33, 15, 688, DateTimeKind.Local).AddTicks(7790), "01.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Image" },
                values: new object[] { new DateTime(2023, 11, 29, 16, 33, 15, 688, DateTimeKind.Local).AddTicks(7790), "02.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Image" },
                values: new object[] { new DateTime(2023, 11, 29, 16, 33, 15, 688, DateTimeKind.Local).AddTicks(7790), "02.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Image" },
                values: new object[] { new DateTime(2023, 11, 29, 16, 33, 15, 688, DateTimeKind.Local).AddTicks(7800), "03.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Image" },
                values: new object[] { new DateTime(2023, 11, 29, 16, 33, 15, 688, DateTimeKind.Local).AddTicks(7800), "03.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Image" },
                values: new object[] { new DateTime(2023, 11, 29, 16, 33, 15, 688, DateTimeKind.Local).AddTicks(7800), "04.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Image" },
                values: new object[] { new DateTime(2023, 11, 29, 16, 33, 15, 688, DateTimeKind.Local).AddTicks(7800), "04.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Image" },
                values: new object[] { new DateTime(2023, 11, 29, 16, 33, 15, 688, DateTimeKind.Local).AddTicks(7810), "05.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Image" },
                values: new object[] { new DateTime(2023, 11, 29, 16, 33, 15, 688, DateTimeKind.Local).AddTicks(7810), "05.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Image" },
                values: new object[] { new DateTime(2023, 11, 29, 16, 33, 15, 688, DateTimeKind.Local).AddTicks(7810), "06.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Image" },
                values: new object[] { new DateTime(2023, 11, 29, 16, 33, 15, 688, DateTimeKind.Local).AddTicks(7820), "06.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Image" },
                values: new object[] { new DateTime(2023, 11, 29, 16, 33, 15, 688, DateTimeKind.Local).AddTicks(7820), "02.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 16, 33, 15, 688, DateTimeKind.Local).AddTicks(7760));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2023, 11, 29, 16, 33, 15, 688, DateTimeKind.Local).AddTicks(7760), 35m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2023, 11, 29, 16, 33, 15, 688, DateTimeKind.Local).AddTicks(7760), 35m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2023, 11, 29, 16, 33, 15, 688, DateTimeKind.Local).AddTicks(7770), 35m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2023, 11, 29, 16, 33, 15, 688, DateTimeKind.Local).AddTicks(7770), 35m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2023, 11, 29, 16, 33, 15, 688, DateTimeKind.Local).AddTicks(7770), 35m });

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
        }
    }
}
