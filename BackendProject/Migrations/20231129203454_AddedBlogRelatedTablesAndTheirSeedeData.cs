using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendProject.Migrations
{
    public partial class AddedBlogRelatedTablesAndTheirSeedeData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
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
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BlogImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsMain = table.Column<bool>(type: "bit", nullable: false),
                    BlogId = table.Column<int>(type: "int", nullable: false),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BlogImages_Blogs_BlogId",
                        column: x => x.BlogId,
                        principalTable: "Blogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BlogTags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlogId = table.Column<int>(type: "int", nullable: false),
                    TagId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogTags", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BlogTags_Blogs_BlogId",
                        column: x => x.BlogId,
                        principalTable: "Blogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BlogTags_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "Id", "CreatedDate", "Description", "SoftDeleted", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2017, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney Colleg Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and goingthrough the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of \"de Finibus Bonorum et Malorum\" (The Extremes of Good and Evil) by Cicero, written in 45 BC. Thisbook is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, \"Lorem ipsum dolor sit amet..\", comes from a line in section 1.10.32.", false, "If you are going to use a passage latin at Hampdun." },
                    { 2, new DateTime(2020, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney Colleg Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and goingthrough the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of \"de Finibus Bonorum et Malorum\" (The Extremes of Good and Evil) by Cicero, written in 45 BC. Thisbook is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, \"Lorem ipsum dolor sit amet..\", comes from a line in section 1.10.32.", false, "If you are going to use a passage latin at Hampdun." },
                    { 3, new DateTime(2018, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.", false, "If you are going to use a passage latin at Hampdun." }
                });

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

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CreatedDate", "Name", "SoftDeleted" },
                values: new object[] { 1, new DateTime(2023, 11, 30, 0, 34, 54, 186, DateTimeKind.Local).AddTicks(3010), "Bestsellers", false });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CreatedDate", "Name", "SoftDeleted" },
                values: new object[,]
                {
                    { 2, new DateTime(2023, 11, 30, 0, 34, 54, 186, DateTimeKind.Local).AddTicks(3010), "Gifts", false },
                    { 3, new DateTime(2023, 11, 30, 0, 34, 54, 186, DateTimeKind.Local).AddTicks(3010), "New", false },
                    { 4, new DateTime(2023, 11, 30, 0, 34, 54, 186, DateTimeKind.Local).AddTicks(3010), "Christmas Gift", false },
                    { 5, new DateTime(2023, 11, 30, 0, 34, 54, 186, DateTimeKind.Local).AddTicks(3020), "Festive Cakes", false },
                    { 6, new DateTime(2023, 11, 30, 0, 34, 54, 186, DateTimeKind.Local).AddTicks(3020), "Home Decor", false },
                    { 7, new DateTime(2023, 11, 30, 0, 34, 54, 186, DateTimeKind.Local).AddTicks(3020), "Toys", false }
                });

            migrationBuilder.InsertData(
                table: "BlogImages",
                columns: new[] { "Id", "BlogId", "CreatedDate", "Image", "IsMain", "SoftDeleted" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 11, 30, 0, 34, 54, 186, DateTimeKind.Local).AddTicks(3060), "1.jpg", true, false },
                    { 2, 1, new DateTime(2023, 11, 30, 0, 34, 54, 186, DateTimeKind.Local).AddTicks(3060), "2.jpg", false, false },
                    { 3, 1, new DateTime(2023, 11, 30, 0, 34, 54, 186, DateTimeKind.Local).AddTicks(3070), "3.jpg", false, false },
                    { 4, 2, new DateTime(2023, 11, 30, 0, 34, 54, 186, DateTimeKind.Local).AddTicks(3070), "2.jpg", true, false },
                    { 5, 2, new DateTime(2023, 11, 30, 0, 34, 54, 186, DateTimeKind.Local).AddTicks(3070), "1.jpg", false, false },
                    { 6, 2, new DateTime(2023, 11, 30, 0, 34, 54, 186, DateTimeKind.Local).AddTicks(3080), "3.jpg", false, false },
                    { 7, 3, new DateTime(2023, 11, 30, 0, 34, 54, 186, DateTimeKind.Local).AddTicks(3080), "3.jpg", true, false },
                    { 8, 3, new DateTime(2023, 11, 30, 0, 34, 54, 186, DateTimeKind.Local).AddTicks(3080), "1.jpg", false, false },
                    { 9, 3, new DateTime(2023, 11, 30, 0, 34, 54, 186, DateTimeKind.Local).AddTicks(3080), "2.jpg", false, false }
                });

            migrationBuilder.InsertData(
                table: "BlogTags",
                columns: new[] { "Id", "BlogId", "TagId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 5 },
                    { 3, 1, 6 },
                    { 4, 1, 4 },
                    { 5, 2, 1 },
                    { 6, 2, 4 },
                    { 7, 2, 3 },
                    { 8, 2, 6 },
                    { 9, 3, 1 },
                    { 10, 3, 2 },
                    { 11, 3, 5 },
                    { 12, 3, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BlogImages_BlogId",
                table: "BlogImages",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogTags_BlogId",
                table: "BlogTags",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogTags_TagId",
                table: "BlogTags",
                column: "TagId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlogImages");

            migrationBuilder.DropTable(
                name: "BlogTags");

            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 56, 21, 608, DateTimeKind.Local).AddTicks(510));

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 56, 21, 608, DateTimeKind.Local).AddTicks(510));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 56, 21, 608, DateTimeKind.Local).AddTicks(560));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 56, 21, 608, DateTimeKind.Local).AddTicks(560));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 56, 21, 608, DateTimeKind.Local).AddTicks(570));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 56, 21, 608, DateTimeKind.Local).AddTicks(570));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 56, 21, 608, DateTimeKind.Local).AddTicks(540));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 56, 21, 608, DateTimeKind.Local).AddTicks(550));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 56, 21, 608, DateTimeKind.Local).AddTicks(550));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 56, 21, 608, DateTimeKind.Local).AddTicks(620));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 56, 21, 608, DateTimeKind.Local).AddTicks(620));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 56, 21, 608, DateTimeKind.Local).AddTicks(630));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 56, 21, 608, DateTimeKind.Local).AddTicks(630));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 56, 21, 608, DateTimeKind.Local).AddTicks(630));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 56, 21, 608, DateTimeKind.Local).AddTicks(640));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 56, 21, 608, DateTimeKind.Local).AddTicks(640));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 56, 21, 608, DateTimeKind.Local).AddTicks(640));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 56, 21, 608, DateTimeKind.Local).AddTicks(640));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 56, 21, 608, DateTimeKind.Local).AddTicks(650));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 56, 21, 608, DateTimeKind.Local).AddTicks(650));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 56, 21, 608, DateTimeKind.Local).AddTicks(650));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 56, 21, 608, DateTimeKind.Local).AddTicks(580));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 56, 21, 608, DateTimeKind.Local).AddTicks(590));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 56, 21, 608, DateTimeKind.Local).AddTicks(590));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 56, 21, 608, DateTimeKind.Local).AddTicks(600));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 56, 21, 608, DateTimeKind.Local).AddTicks(600));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 56, 21, 608, DateTimeKind.Local).AddTicks(610));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 56, 21, 608, DateTimeKind.Local).AddTicks(530));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 56, 21, 608, DateTimeKind.Local).AddTicks(530));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 56, 21, 608, DateTimeKind.Local).AddTicks(530));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 56, 21, 608, DateTimeKind.Local).AddTicks(670));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 56, 21, 608, DateTimeKind.Local).AddTicks(670));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 56, 21, 608, DateTimeKind.Local).AddTicks(680));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 56, 21, 608, DateTimeKind.Local).AddTicks(680));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 56, 21, 608, DateTimeKind.Local).AddTicks(680));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 56, 21, 608, DateTimeKind.Local).AddTicks(690));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 56, 21, 608, DateTimeKind.Local).AddTicks(350));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 56, 21, 608, DateTimeKind.Local).AddTicks(380));
        }
    }
}
