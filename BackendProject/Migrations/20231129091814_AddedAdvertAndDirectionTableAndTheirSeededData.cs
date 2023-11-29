using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendProject.Migrations
{
    public partial class AddedAdvertAndDirectionTableAndTheirSeededData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Directions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Directions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Adverts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DirectionId = table.Column<int>(type: "int", nullable: false),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adverts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Adverts_Directions_DirectionId",
                        column: x => x.DirectionId,
                        principalTable: "Directions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Directions",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "right" },
                    { 2, "left" }
                });

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

            migrationBuilder.InsertData(
                table: "Adverts",
                columns: new[] { "Id", "CreatedDate", "Description", "DirectionId", "Image", "SoftDeleted" },
                values: new object[] { 1, new DateTime(2023, 11, 29, 13, 18, 14, 75, DateTimeKind.Local).AddTicks(7190), "<h1 class=\"white\"><span>Gifts</span>Christmas</h1>", 1, "1.jpg", false });

            migrationBuilder.InsertData(
                table: "Adverts",
                columns: new[] { "Id", "CreatedDate", "Description", "DirectionId", "Image", "SoftDeleted" },
                values: new object[] { 2, new DateTime(2023, 11, 29, 13, 18, 14, 75, DateTimeKind.Local).AddTicks(7190), "<h2 class=\"black\"><span class=\"small\">Save <span class=\"red\">25%</span></span><span class=\"red\">Offer</span> Christmas</h2>", 2, "2.jpg", false });

            migrationBuilder.CreateIndex(
                name: "IX_Adverts_DirectionId",
                table: "Adverts",
                column: "DirectionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adverts");

            migrationBuilder.DropTable(
                name: "Directions");

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 12, 23, 45, 914, DateTimeKind.Local).AddTicks(6900));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 12, 23, 45, 914, DateTimeKind.Local).AddTicks(6920));
        }
    }
}
