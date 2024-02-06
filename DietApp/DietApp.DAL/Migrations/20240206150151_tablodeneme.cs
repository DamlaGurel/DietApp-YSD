using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DietApp.DAL.Migrations
{
    public partial class tablodeneme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GunlukRapor",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SecilenRaporTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    YemekAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SuMiktari = table.Column<int>(type: "int", nullable: false),
                    Kalori = table.Column<double>(type: "float", nullable: false),
                    KarbonhidratMiktari = table.Column<double>(type: "float", nullable: false),
                    ProteinMiktari = table.Column<double>(type: "float", nullable: false),
                    YagMiktari = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GunlukRapor", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Kategori",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategoriAdi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategori", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "KullaniciGiris",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sifre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KullaniciGiris", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Ogun",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OgunAdi = table.Column<int>(type: "int", nullable: false),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Kalori = table.Column<double>(type: "float", nullable: false),
                    KarbonhidratMiktari = table.Column<double>(type: "float", nullable: false),
                    ProteinMiktari = table.Column<double>(type: "float", nullable: false),
                    YagMiktari = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogun", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "OgunKullanici",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OgunKullanici", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Su",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SuMiktari = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Su", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Yemek",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YemekAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KategoriID = table.Column<int>(type: "int", nullable: false),
                    Karbonhidrat = table.Column<double>(type: "float", nullable: false),
                    Yag = table.Column<double>(type: "float", nullable: false),
                    Protein = table.Column<double>(type: "float", nullable: false),
                    Kalori = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yemek", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Yemek_Kategori_KategoriID",
                        column: x => x.KategoriID,
                        principalTable: "Kategori",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KullaniciKisisel",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Isim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyisim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cinsiyet = table.Column<bool>(type: "bit", nullable: false),
                    Yas = table.Column<int>(type: "int", nullable: false),
                    Boy = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Kilo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    HedefKilo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GunlukKalori = table.Column<double>(type: "float", nullable: false),
                    SuMiktari = table.Column<double>(type: "float", nullable: false),
                    BaslangicTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BitisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OgunID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KullaniciKisisel", x => x.ID);
                    table.ForeignKey(
                        name: "FK_KullaniciKisisel_Ogun_OgunID",
                        column: x => x.OgunID,
                        principalTable: "Ogun",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "YemekMiktari",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MiktarGr = table.Column<double>(type: "float", nullable: false),
                    YenilenYemekID = table.Column<int>(type: "int", nullable: false),
                    Kalori = table.Column<double>(type: "float", nullable: false),
                    KarbonhidratMiktari = table.Column<double>(type: "float", nullable: false),
                    ProteinMiktari = table.Column<double>(type: "float", nullable: false),
                    YagMiktari = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YemekMiktari", x => x.ID);
                    table.ForeignKey(
                        name: "FK_YemekMiktari_Yemek_YenilenYemekID",
                        column: x => x.YenilenYemekID,
                        principalTable: "Yemek",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "YemekOgun",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YemekID = table.Column<int>(type: "int", nullable: false),
                    OgunID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YemekOgun", x => x.ID);
                    table.ForeignKey(
                        name: "FK_YemekOgun_Ogun_OgunID",
                        column: x => x.OgunID,
                        principalTable: "Ogun",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_YemekOgun_Yemek_YemekID",
                        column: x => x.YemekID,
                        principalTable: "Yemek",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_KullaniciKisisel_OgunID",
                table: "KullaniciKisisel",
                column: "OgunID");

            migrationBuilder.CreateIndex(
                name: "IX_Yemek_KategoriID",
                table: "Yemek",
                column: "KategoriID");

            migrationBuilder.CreateIndex(
                name: "IX_YemekMiktari_YenilenYemekID",
                table: "YemekMiktari",
                column: "YenilenYemekID");

            migrationBuilder.CreateIndex(
                name: "IX_YemekOgun_OgunID",
                table: "YemekOgun",
                column: "OgunID");

            migrationBuilder.CreateIndex(
                name: "IX_YemekOgun_YemekID",
                table: "YemekOgun",
                column: "YemekID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GunlukRapor");

            migrationBuilder.DropTable(
                name: "KullaniciGiris");

            migrationBuilder.DropTable(
                name: "KullaniciKisisel");

            migrationBuilder.DropTable(
                name: "OgunKullanici");

            migrationBuilder.DropTable(
                name: "Su");

            migrationBuilder.DropTable(
                name: "YemekMiktari");

            migrationBuilder.DropTable(
                name: "YemekOgun");

            migrationBuilder.DropTable(
                name: "Ogun");

            migrationBuilder.DropTable(
                name: "Yemek");

            migrationBuilder.DropTable(
                name: "Kategori");
        }
    }
}
