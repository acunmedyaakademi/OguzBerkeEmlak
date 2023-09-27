using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class addportfoy2calisan : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PortfoySahibi",
                table: "Portfoyler");

            migrationBuilder.DropColumn(
                name: "PortfoySahibi2ID",
                table: "Portfoyler");

            migrationBuilder.DropColumn(
                name: "PortfoySahibiID",
                table: "Portfoyler");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Role",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 27, 13, 48, 53, 705, DateTimeKind.Local).AddTicks(2545),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 27, 13, 43, 46, 983, DateTimeKind.Local).AddTicks(8575));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Portfoyler",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 27, 13, 48, 53, 705, DateTimeKind.Local).AddTicks(6986),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 27, 13, 43, 46, 984, DateTimeKind.Local).AddTicks(3555));

            migrationBuilder.AddColumn<int>(
                name: "CalisanId",
                table: "Portfoyler",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Menu",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 27, 13, 48, 53, 705, DateTimeKind.Local).AddTicks(76),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 27, 13, 43, 46, 983, DateTimeKind.Local).AddTicks(5782));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Calisanlar",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 27, 13, 48, 53, 705, DateTimeKind.Local).AddTicks(5117),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 27, 13, 43, 46, 984, DateTimeKind.Local).AddTicks(1393));

            migrationBuilder.CreateIndex(
                name: "IX_Portfoyler_CalisanId",
                table: "Portfoyler",
                column: "CalisanId");

            migrationBuilder.AddForeignKey(
                name: "FK_Portfoyler_Calisanlar_CalisanId",
                table: "Portfoyler",
                column: "CalisanId",
                principalTable: "Calisanlar",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Portfoyler_Calisanlar_CalisanId",
                table: "Portfoyler");

            migrationBuilder.DropIndex(
                name: "IX_Portfoyler_CalisanId",
                table: "Portfoyler");

            migrationBuilder.DropColumn(
                name: "CalisanId",
                table: "Portfoyler");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Role",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 27, 13, 43, 46, 983, DateTimeKind.Local).AddTicks(8575),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 27, 13, 48, 53, 705, DateTimeKind.Local).AddTicks(2545));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Portfoyler",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 27, 13, 43, 46, 984, DateTimeKind.Local).AddTicks(3555),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 27, 13, 48, 53, 705, DateTimeKind.Local).AddTicks(6986));

            migrationBuilder.AddColumn<string>(
                name: "PortfoySahibi",
                table: "Portfoyler",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "PortfoySahibi2ID",
                table: "Portfoyler",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PortfoySahibiID",
                table: "Portfoyler",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Menu",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 27, 13, 43, 46, 983, DateTimeKind.Local).AddTicks(5782),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 27, 13, 48, 53, 705, DateTimeKind.Local).AddTicks(76));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Calisanlar",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 27, 13, 43, 46, 984, DateTimeKind.Local).AddTicks(1393),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 27, 13, 48, 53, 705, DateTimeKind.Local).AddTicks(5117));
        }
    }
}
