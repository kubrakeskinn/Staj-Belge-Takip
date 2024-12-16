using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Etu.StajSistemi.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OgrenciVesikalikFileContent",
                table: "AppOgrenciStajBasvurusus",
                newName: "OgrenciVesikalikFileContentType");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OgrenciVesikalikFileContentType",
                table: "AppOgrenciStajBasvurusus",
                newName: "OgrenciVesikalikFileContent");
        }
    }
}
