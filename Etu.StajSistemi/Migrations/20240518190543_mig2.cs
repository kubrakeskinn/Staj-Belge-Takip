using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Etu.StajSistemi.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "BolumBaskaniOnayTarihi",
                table: "AppOgrenciStajBasvurusus",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BolumBaskaniOnayTarihi",
                table: "AppOgrenciStajBasvurusus");
        }
    }
}
