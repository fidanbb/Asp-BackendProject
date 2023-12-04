using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendProject.Migrations
{
    public partial class AddedIdentityTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5810));

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5360));

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5360));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5660));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5660));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5660));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5670));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5670));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5670));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5670));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5680));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5680));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5680));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5680));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5690));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5690));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5690));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5690));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5710));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5710));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5710));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5710));

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5710));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5850));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5850));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5850));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5850));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5860));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5860));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5430));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5440));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5440));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5440));

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5900));

            migrationBuilder.UpdateData(
                table: "ContactMessages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5910));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5410));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5410));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5410));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5410));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5420));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5490));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5490));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5490));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5500));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5500));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5500));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5500));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5510));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5510));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5510));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5510));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5520));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5450));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5460));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5470));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5470));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5470));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5470));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5380));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5380));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5380));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5380));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5390));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5390));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5540));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5540));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5540));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5550));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5550));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5550));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5160));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5200));

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5870));

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5880));

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5880));

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5880));

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5880));

            migrationBuilder.UpdateData(
                table: "Subscribes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5780));

            migrationBuilder.UpdateData(
                table: "Subscribes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5790));

            migrationBuilder.UpdateData(
                table: "Subscribes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5790));

            migrationBuilder.UpdateData(
                table: "Subscribes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5790));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5570));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5570));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5570));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5570));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5580));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5580));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5580));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5820));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5830));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5830));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 2, 0, 37, 14, 408, DateTimeKind.Local).AddTicks(5830));
        }
    }
}
