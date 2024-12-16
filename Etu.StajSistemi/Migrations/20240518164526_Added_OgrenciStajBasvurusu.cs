using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Etu.StajSistemi.Migrations
{
    /// <inheritdoc />
    public partial class Added_OgrenciStajBasvurusu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AbpBlobContainers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenantId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpBlobContainers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppOgrenciStajBasvurusus",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GunSayisi = table.Column<int>(type: "int", maxLength: 365, nullable: false),
                    BolumBaskaniAdiSoyadi = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    BolumBaskaniImzasi = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    BolumBaskaniImzasiContentType = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    OgrenciAdiSoyadi = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    OgrenciNo = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    OgrenciBolumu = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    OgrenciOgretimYili = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    OgrenciTelefonNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OgrenciEposta = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    OgrenciAdresi = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    OgrenciVesikalikFileName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    OgrenciVesikalikFileContent = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    KurulusAdi = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    KurulusTelefonNo = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    KurulusAdresi = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    StajYeriYetkilisiAdiSoyadi = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    StajYeriYetkilisiGorevVeUnvani = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    StajYeriYetkilisiEpostaAdresi = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    StajYeriYetkilisiOnayTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StajYeriYetkilisiImzaFileName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    StajYeriYetkilisiImzaContentType = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    OgrenciStajBaslamaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OgrenciStajBitisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OgrenciAdi = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    OgrenciSoyadi = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    OgrenciTcKimlikNo = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    OgrenciSskNo = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    OgrenciBabaAdi = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    OgrenciAnaAdi = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    OgrenciDogumYeri = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    OgrenciDogumTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OgrenciSaglikGuvencesi = table.Column<int>(type: "int", nullable: false),
                    BolumStajKomisyonuBaskanOnayiTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BolumStajKomisyonuBaskanOnayiImzaFileName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    BolumStajKomisyonuBaskanOnayiImzaContentType = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    DekanlikOnayTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DekanlikOnayImzaFileName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    DekanlikOnayImzaFileContentType = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    SksDaireBaskanligiOnayTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SksDaireBaskanligiOnayImzaFileName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    SksDaireBaskanligiOnayImzaFileContentType = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    OgrenciImzaFileName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    OgrenciImzaFileContentType = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppOgrenciStajBasvurusus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AbpBlobs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ContainerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenantId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Content = table.Column<byte[]>(type: "varbinary(max)", maxLength: 2147483647, nullable: true),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpBlobs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AbpBlobs_AbpBlobContainers_ContainerId",
                        column: x => x.ContainerId,
                        principalTable: "AbpBlobContainers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AbpBlobContainers_TenantId_Name",
                table: "AbpBlobContainers",
                columns: new[] { "TenantId", "Name" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpBlobs_ContainerId",
                table: "AbpBlobs",
                column: "ContainerId");

            migrationBuilder.CreateIndex(
                name: "IX_AbpBlobs_TenantId_ContainerId_Name",
                table: "AbpBlobs",
                columns: new[] { "TenantId", "ContainerId", "Name" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AbpBlobs");

            migrationBuilder.DropTable(
                name: "AppOgrenciStajBasvurusus");

            migrationBuilder.DropTable(
                name: "AbpBlobContainers");
        }
    }
}
