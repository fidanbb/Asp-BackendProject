using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendProject.Migrations
{
    public partial class AddedNewSeededDataToBlogRelatedTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 9, 47, 56, 322, DateTimeKind.Local).AddTicks(3730));

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 9, 47, 56, 322, DateTimeKind.Local).AddTicks(3740));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 9, 47, 56, 322, DateTimeKind.Local).AddTicks(4010));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 9, 47, 56, 322, DateTimeKind.Local).AddTicks(4010));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 9, 47, 56, 322, DateTimeKind.Local).AddTicks(4010));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 9, 47, 56, 322, DateTimeKind.Local).AddTicks(4010));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 9, 47, 56, 322, DateTimeKind.Local).AddTicks(4020));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 9, 47, 56, 322, DateTimeKind.Local).AddTicks(4020));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 9, 47, 56, 322, DateTimeKind.Local).AddTicks(4020));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 9, 47, 56, 322, DateTimeKind.Local).AddTicks(4030));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 9, 47, 56, 322, DateTimeKind.Local).AddTicks(4030));

            migrationBuilder.InsertData(
                table: "BlogImages",
                columns: new[] { "Id", "BlogId", "CreatedDate", "Image", "IsMain", "SoftDeleted" },
                values: new object[,]
                {
                    { 13, 2, new DateTime(2023, 11, 30, 9, 47, 56, 322, DateTimeKind.Local).AddTicks(4040), "2.jpg", true, false },
                    { 14, 2, new DateTime(2023, 11, 30, 9, 47, 56, 322, DateTimeKind.Local).AddTicks(4040), "1.jpg", false, false },
                    { 15, 2, new DateTime(2023, 11, 30, 9, 47, 56, 322, DateTimeKind.Local).AddTicks(4040), "3.jpg", false, false },
                    { 16, 3, new DateTime(2023, 11, 30, 9, 47, 56, 322, DateTimeKind.Local).AddTicks(4050), "3.jpg", true, false },
                    { 17, 3, new DateTime(2023, 11, 30, 9, 47, 56, 322, DateTimeKind.Local).AddTicks(4050), "1.jpg", false, false },
                    { 18, 3, new DateTime(2023, 11, 30, 9, 47, 56, 322, DateTimeKind.Local).AddTicks(4050), "2.jpg", false, false },
                    { 19, 2, new DateTime(2023, 11, 30, 9, 47, 56, 322, DateTimeKind.Local).AddTicks(4060), "2.jpg", true, false },
                    { 20, 2, new DateTime(2023, 11, 30, 9, 47, 56, 322, DateTimeKind.Local).AddTicks(4060), "1.jpg", false, false },
                    { 21, 2, new DateTime(2023, 11, 30, 9, 47, 56, 322, DateTimeKind.Local).AddTicks(4060), "3.jpg", false, false },
                    { 22, 3, new DateTime(2023, 11, 30, 9, 47, 56, 322, DateTimeKind.Local).AddTicks(4060), "3.jpg", true, false },
                    { 23, 3, new DateTime(2023, 11, 30, 9, 47, 56, 322, DateTimeKind.Local).AddTicks(4060), "1.jpg", false, false },
                    { 24, 3, new DateTime(2023, 11, 30, 9, 47, 56, 322, DateTimeKind.Local).AddTicks(4070), "2.jpg", false, false }
                });

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "Id", "CreatedDate", "Description", "SoftDeleted", "Title" },
                values: new object[,]
                {
                    { 4, new DateTime(2023, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.", false, "If you are going to use a passage latin at Hampdun." },
                    { 5, new DateTime(2022, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.", false, "If you are going to use a passage latin at Hampdun." },
                    { 6, new DateTime(2021, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.", false, "If you are going to use a passage latin at Hampdun." },
                    { 7, new DateTime(2019, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.", false, "If you are going to use a passage latin at Hampdun." },
                    { 8, new DateTime(2017, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.", false, "If you are going to use a passage latin at Hampdun." }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 9, 47, 56, 322, DateTimeKind.Local).AddTicks(3790));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 9, 47, 56, 322, DateTimeKind.Local).AddTicks(3790));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 9, 47, 56, 322, DateTimeKind.Local).AddTicks(3790));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 9, 47, 56, 322, DateTimeKind.Local).AddTicks(3800));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 9, 47, 56, 322, DateTimeKind.Local).AddTicks(3770));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 9, 47, 56, 322, DateTimeKind.Local).AddTicks(3770));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 9, 47, 56, 322, DateTimeKind.Local).AddTicks(3780));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 9, 47, 56, 322, DateTimeKind.Local).AddTicks(3850));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 9, 47, 56, 322, DateTimeKind.Local).AddTicks(3850));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 9, 47, 56, 322, DateTimeKind.Local).AddTicks(3860));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 9, 47, 56, 322, DateTimeKind.Local).AddTicks(3860));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 9, 47, 56, 322, DateTimeKind.Local).AddTicks(3860));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 9, 47, 56, 322, DateTimeKind.Local).AddTicks(3860));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 9, 47, 56, 322, DateTimeKind.Local).AddTicks(3860));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 9, 47, 56, 322, DateTimeKind.Local).AddTicks(3870));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 9, 47, 56, 322, DateTimeKind.Local).AddTicks(3870));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 9, 47, 56, 322, DateTimeKind.Local).AddTicks(3870));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 9, 47, 56, 322, DateTimeKind.Local).AddTicks(3880));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 9, 47, 56, 322, DateTimeKind.Local).AddTicks(3880));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 9, 47, 56, 322, DateTimeKind.Local).AddTicks(3810));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 9, 47, 56, 322, DateTimeKind.Local).AddTicks(3820));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 9, 47, 56, 322, DateTimeKind.Local).AddTicks(3820));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 9, 47, 56, 322, DateTimeKind.Local).AddTicks(3820));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 9, 47, 56, 322, DateTimeKind.Local).AddTicks(3830));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 9, 47, 56, 322, DateTimeKind.Local).AddTicks(3830));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 9, 47, 56, 322, DateTimeKind.Local).AddTicks(3750));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 9, 47, 56, 322, DateTimeKind.Local).AddTicks(3750));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 9, 47, 56, 322, DateTimeKind.Local).AddTicks(3760));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 9, 47, 56, 322, DateTimeKind.Local).AddTicks(3900));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 9, 47, 56, 322, DateTimeKind.Local).AddTicks(3900));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 9, 47, 56, 322, DateTimeKind.Local).AddTicks(3910));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 9, 47, 56, 322, DateTimeKind.Local).AddTicks(3910));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 9, 47, 56, 322, DateTimeKind.Local).AddTicks(3910));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 9, 47, 56, 322, DateTimeKind.Local).AddTicks(3910));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 9, 47, 56, 322, DateTimeKind.Local).AddTicks(3580));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 9, 47, 56, 322, DateTimeKind.Local).AddTicks(3620));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 9, 47, 56, 322, DateTimeKind.Local).AddTicks(3930));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 9, 47, 56, 322, DateTimeKind.Local).AddTicks(3930));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 9, 47, 56, 322, DateTimeKind.Local).AddTicks(3940));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 9, 47, 56, 322, DateTimeKind.Local).AddTicks(3940));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 9, 47, 56, 322, DateTimeKind.Local).AddTicks(3940));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 9, 47, 56, 322, DateTimeKind.Local).AddTicks(3950));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 9, 47, 56, 322, DateTimeKind.Local).AddTicks(3950));

            migrationBuilder.InsertData(
                table: "BlogImages",
                columns: new[] { "Id", "BlogId", "CreatedDate", "Image", "IsMain", "SoftDeleted" },
                values: new object[,]
                {
                    { 10, 4, new DateTime(2023, 11, 30, 9, 47, 56, 322, DateTimeKind.Local).AddTicks(4030), "1.jpg", true, false },
                    { 11, 4, new DateTime(2023, 11, 30, 9, 47, 56, 322, DateTimeKind.Local).AddTicks(4030), "2.jpg", false, false },
                    { 12, 4, new DateTime(2023, 11, 30, 9, 47, 56, 322, DateTimeKind.Local).AddTicks(4040), "3.jpg", false, false }
                });

            migrationBuilder.InsertData(
                table: "BlogTags",
                columns: new[] { "Id", "BlogId", "TagId" },
                values: new object[,]
                {
                    { 13, 4, 1 },
                    { 14, 4, 5 },
                    { 15, 4, 6 },
                    { 16, 5, 4 },
                    { 17, 5, 1 },
                    { 18, 5, 4 },
                    { 19, 6, 3 },
                    { 20, 6, 6 },
                    { 21, 6, 1 },
                    { 22, 7, 2 },
                    { 23, 7, 5 },
                    { 24, 7, 3 },
                    { 25, 8, 6 },
                    { 26, 8, 1 },
                    { 27, 8, 2 },
                    { 28, 8, 5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 0, 34, 54, 186, DateTimeKind.Local).AddTicks(2810));

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 0, 34, 54, 186, DateTimeKind.Local).AddTicks(2810));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 0, 34, 54, 186, DateTimeKind.Local).AddTicks(3060));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 0, 34, 54, 186, DateTimeKind.Local).AddTicks(3060));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 0, 34, 54, 186, DateTimeKind.Local).AddTicks(3070));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 0, 34, 54, 186, DateTimeKind.Local).AddTicks(3070));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 0, 34, 54, 186, DateTimeKind.Local).AddTicks(3070));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 0, 34, 54, 186, DateTimeKind.Local).AddTicks(3080));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 0, 34, 54, 186, DateTimeKind.Local).AddTicks(3080));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 0, 34, 54, 186, DateTimeKind.Local).AddTicks(3080));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 0, 34, 54, 186, DateTimeKind.Local).AddTicks(3080));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 0, 34, 54, 186, DateTimeKind.Local).AddTicks(2870));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 0, 34, 54, 186, DateTimeKind.Local).AddTicks(2870));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 0, 34, 54, 186, DateTimeKind.Local).AddTicks(2880));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 0, 34, 54, 186, DateTimeKind.Local).AddTicks(2880));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 0, 34, 54, 186, DateTimeKind.Local).AddTicks(2850));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 0, 34, 54, 186, DateTimeKind.Local).AddTicks(2850));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 0, 34, 54, 186, DateTimeKind.Local).AddTicks(2850));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 0, 34, 54, 186, DateTimeKind.Local).AddTicks(2930));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 0, 34, 54, 186, DateTimeKind.Local).AddTicks(2930));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 0, 34, 54, 186, DateTimeKind.Local).AddTicks(2940));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 0, 34, 54, 186, DateTimeKind.Local).AddTicks(2940));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 0, 34, 54, 186, DateTimeKind.Local).AddTicks(2940));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 0, 34, 54, 186, DateTimeKind.Local).AddTicks(2940));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 0, 34, 54, 186, DateTimeKind.Local).AddTicks(2950));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 0, 34, 54, 186, DateTimeKind.Local).AddTicks(2950));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 0, 34, 54, 186, DateTimeKind.Local).AddTicks(2950));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 0, 34, 54, 186, DateTimeKind.Local).AddTicks(2950));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 0, 34, 54, 186, DateTimeKind.Local).AddTicks(2960));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 0, 34, 54, 186, DateTimeKind.Local).AddTicks(2960));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 0, 34, 54, 186, DateTimeKind.Local).AddTicks(2890));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 0, 34, 54, 186, DateTimeKind.Local).AddTicks(2900));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 0, 34, 54, 186, DateTimeKind.Local).AddTicks(2900));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 0, 34, 54, 186, DateTimeKind.Local).AddTicks(2910));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 0, 34, 54, 186, DateTimeKind.Local).AddTicks(2910));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 0, 34, 54, 186, DateTimeKind.Local).AddTicks(2910));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 0, 34, 54, 186, DateTimeKind.Local).AddTicks(2830));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 0, 34, 54, 186, DateTimeKind.Local).AddTicks(2830));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 0, 34, 54, 186, DateTimeKind.Local).AddTicks(2830));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 0, 34, 54, 186, DateTimeKind.Local).AddTicks(2980));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 0, 34, 54, 186, DateTimeKind.Local).AddTicks(2980));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 0, 34, 54, 186, DateTimeKind.Local).AddTicks(2980));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 0, 34, 54, 186, DateTimeKind.Local).AddTicks(2990));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 0, 34, 54, 186, DateTimeKind.Local).AddTicks(2990));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 0, 34, 54, 186, DateTimeKind.Local).AddTicks(2990));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 0, 34, 54, 186, DateTimeKind.Local).AddTicks(2680));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 0, 34, 54, 186, DateTimeKind.Local).AddTicks(2710));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 0, 34, 54, 186, DateTimeKind.Local).AddTicks(3010));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 0, 34, 54, 186, DateTimeKind.Local).AddTicks(3010));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 0, 34, 54, 186, DateTimeKind.Local).AddTicks(3010));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 0, 34, 54, 186, DateTimeKind.Local).AddTicks(3010));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 0, 34, 54, 186, DateTimeKind.Local).AddTicks(3020));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 0, 34, 54, 186, DateTimeKind.Local).AddTicks(3020));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 0, 34, 54, 186, DateTimeKind.Local).AddTicks(3020));
        }
    }
}
