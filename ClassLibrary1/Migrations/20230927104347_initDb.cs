using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class initDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Portfoyler",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PortfoyID = table.Column<int>(type: "int", nullable: false),
                    PortfoyTipi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PortfoyAdres = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    PortfoySahibiID = table.Column<int>(type: "int", nullable: false),
                    PortfoySahibi2ID = table.Column<int>(type: "int", nullable: false),
                    PortfoySahibi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MetrekareAlan = table.Column<double>(type: "float", nullable: false),
                    PortfoyDurumu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PortfoyTutar = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PortfoyAciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 27, 13, 43, 46, 984, DateTimeKind.Local).AddTicks(3555)),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Portfoyler", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 27, 13, 43, 46, 983, DateTimeKind.Local).AddTicks(8575)),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Calisanlar",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsimSoyisim = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    KullaniciAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KullaniciSifre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GSM = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    GSM2 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mail2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PortfoySayisi = table.Column<int>(type: "int", nullable: true),
                    RoleId = table.Column<int>(type: "int", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 27, 13, 43, 46, 984, DateTimeKind.Local).AddTicks(1393)),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calisanlar", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Calisanlar_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Menu",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Area = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Controller = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Action = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CssClass = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IconClass = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CssClass2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IconClass2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 27, 13, 43, 46, 983, DateTimeKind.Local).AddTicks(5782)),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Menu_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Calisanlar_RoleId",
                table: "Calisanlar",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Menu_RoleId",
                table: "Menu",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Role_RoleName",
                table: "Role",
                column: "RoleName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Calisanlar");

            migrationBuilder.DropTable(
                name: "Menu");

            migrationBuilder.DropTable(
                name: "Portfoyler");

            migrationBuilder.DropTable(
                name: "Role");
        }
    }
}
