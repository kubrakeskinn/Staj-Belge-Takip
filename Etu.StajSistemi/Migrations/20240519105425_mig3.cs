using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Etu.StajSistemi.Migrations
{
    /// <inheritdoc />
    public partial class mig3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BasvuruDurumu",
                table: "AppOgrenciStajBasvurusus",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "BasvuruRedAciklamasi",
                table: "AppOgrenciStajBasvurusus",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "BasvuruRedTarihi",
                table: "AppOgrenciStajBasvurusus",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BasvuruDurumu",
                table: "AppOgrenciStajBasvurusus");

            migrationBuilder.DropColumn(
                name: "BasvuruRedAciklamasi",
                table: "AppOgrenciStajBasvurusus");

            migrationBuilder.DropColumn(
                name: "BasvuruRedTarihi",
                table: "AppOgrenciStajBasvurusus");
        }
    }
}
