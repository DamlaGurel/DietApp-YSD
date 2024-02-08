using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DietApp.DAL.Migrations
{
    public partial class a : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    Sifre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KullaniciKisiselID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KullaniciGiris", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Yemek",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YemekAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KategoriID = table.Column<int>(type: "int", nullable: false),
                    Kalori = table.Column<double>(type: "float", nullable: false),
                    KarbonhidratMiktari = table.Column<double>(type: "float", nullable: false),
                    ProteinMiktari = table.Column<double>(type: "float", nullable: false),
                    YagMiktari = table.Column<double>(type: "float", nullable: false)
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
                    HedefSuMiktari = table.Column<double>(type: "float", nullable: false),
                    BaslangicTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BitisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KullaniciGirisID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KullaniciKisisel", x => x.ID);
                    table.ForeignKey(
                        name: "FK_KullaniciKisisel_KullaniciGiris_KullaniciGirisID",
                        column: x => x.KullaniciGirisID,
                        principalTable: "KullaniciGiris",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "YemekMiktari",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MiktarGr = table.Column<double>(type: "float", nullable: false),
                    YemekID = table.Column<int>(type: "int", nullable: false),
                    Kalori = table.Column<double>(type: "float", nullable: false),
                    KarbonhidratMiktari = table.Column<double>(type: "float", nullable: false),
                    ProteinMiktari = table.Column<double>(type: "float", nullable: false),
                    YagMiktari = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YemekMiktari", x => x.ID);
                    table.ForeignKey(
                        name: "FK_YemekMiktari_Yemek_YemekID",
                        column: x => x.YemekID,
                        principalTable: "Yemek",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GunlukRapor",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SecilenRaporTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    YemekAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SuMiktari = table.Column<int>(type: "int", nullable: false),
                    KullaniciKisiselID = table.Column<int>(type: "int", nullable: true),
                    Kalori = table.Column<double>(type: "float", nullable: false),
                    KarbonhidratMiktari = table.Column<double>(type: "float", nullable: false),
                    ProteinMiktari = table.Column<double>(type: "float", nullable: false),
                    YagMiktari = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GunlukRapor", x => x.ID);
                    table.ForeignKey(
                        name: "FK_GunlukRapor_KullaniciKisisel_KullaniciKisiselID",
                        column: x => x.KullaniciKisiselID,
                        principalTable: "KullaniciKisisel",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Su",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SuMiktari = table.Column<double>(type: "float", nullable: false),
                    KullaniciKisiselId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Su", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Su_KullaniciKisisel_KullaniciKisiselId",
                        column: x => x.KullaniciKisiselId,
                        principalTable: "KullaniciKisisel",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ogun",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OgunAdi = table.Column<int>(type: "int", nullable: false),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KullaniciKisiselID = table.Column<int>(type: "int", nullable: false),
                    GunlukRaporID = table.Column<int>(type: "int", nullable: true),
                    Kalori = table.Column<double>(type: "float", nullable: false),
                    KarbonhidratMiktari = table.Column<double>(type: "float", nullable: false),
                    ProteinMiktari = table.Column<double>(type: "float", nullable: false),
                    YagMiktari = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogun", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Ogun_GunlukRapor_GunlukRaporID",
                        column: x => x.GunlukRaporID,
                        principalTable: "GunlukRapor",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Ogun_KullaniciKisisel_KullaniciKisiselID",
                        column: x => x.KullaniciKisiselID,
                        principalTable: "KullaniciKisisel",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "YemekMiktarOgun",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YemekMiktarID = table.Column<int>(type: "int", nullable: false),
                    OgunID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YemekMiktarOgun", x => x.ID);
                    table.ForeignKey(
                        name: "FK_YemekMiktarOgun_Ogun_OgunID",
                        column: x => x.OgunID,
                        principalTable: "Ogun",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_YemekMiktarOgun_YemekMiktari_YemekMiktarID",
                        column: x => x.YemekMiktarID,
                        principalTable: "YemekMiktari",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Kategori",
                columns: new[] { "ID", "KategoriAdi" },
                values: new object[] { 1, "Meyve" });

            migrationBuilder.InsertData(
                table: "KullaniciGiris",
                columns: new[] { "ID", "KullaniciAdi", "KullaniciKisiselID", "Sifre" },
                values: new object[,]
                {
                    { 1, "YalinTuzmen", 1, "A665A45920422F9D417E4867EFDC4FB8A04A1F3FFF1FA07E998E86F7F7A27AE3" },
                    { 2, "SilaYildirim", 2, "A665A45920422F9D417E4867EFDC4FB8A04A1F3FFF1FA07E998E86F7F7A27AE3" },
                    { 3, "DamlaGurel", 3, "A665A45920422F9D417E4867EFDC4FB8A04A1F3FFF1FA07E998E86F7F7A27AE3" },
                    { 4, "admin", 4, "8C6976E5B5410415BDE908BD4DEE15DFB167A9C873FC4BB8A81F6F2AB448A918" },
                    { 5, "a", 5, "CA978112CA1BBDCAFAC231B39A23DC4DA786EFF8147C4E72B9807785AFEE48BB" }
                });

            migrationBuilder.InsertData(
                table: "KullaniciKisisel",
                columns: new[] { "ID", "BaslangicTarihi", "BitisTarihi", "Boy", "Cinsiyet", "GunlukKalori", "HedefKilo", "HedefSuMiktari", "Isim", "Kilo", "KullaniciGirisID", "Soyisim", "Yas" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 8, 14, 40, 4, 328, DateTimeKind.Local).AddTicks(840), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 170m, false, 3000.0, 70m, 2000.0, "ahmet", 80m, 1, "mehmet", 18 },
                    { 2, new DateTime(2024, 2, 8, 14, 40, 4, 328, DateTimeKind.Local).AddTicks(849), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 170m, false, 3000.0, 70m, 2000.0, "ahmet", 80m, 2, "mehmet", 18 },
                    { 3, new DateTime(2024, 2, 8, 14, 40, 4, 328, DateTimeKind.Local).AddTicks(851), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 170m, false, 3000.0, 70m, 2000.0, "ahmet", 80m, 3, "mehmet", 18 },
                    { 4, new DateTime(2024, 2, 8, 14, 40, 4, 328, DateTimeKind.Local).AddTicks(852), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 170m, false, 3000.0, 70m, 2000.0, "ahmet", 80m, 4, "mehmet", 18 },
                    { 5, new DateTime(2024, 2, 8, 14, 40, 4, 328, DateTimeKind.Local).AddTicks(854), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 170m, false, 3000.0, 70m, 2000.0, "admin", 80m, 5, "adminoğlu", 18 }
                });

            migrationBuilder.InsertData(
                table: "Yemek",
                columns: new[] { "ID", "Kalori", "KarbonhidratMiktari", "KategoriID", "ProteinMiktari", "YagMiktari", "YemekAdi" },
                values: new object[] { 1, 95.0, 19.0, 1, 0.29999999999999999, 0.29999999999999999, "Elma" });

            migrationBuilder.CreateIndex(
                name: "IX_GunlukRapor_KullaniciKisiselID",
                table: "GunlukRapor",
                column: "KullaniciKisiselID");

            migrationBuilder.CreateIndex(
                name: "IX_KullaniciKisisel_KullaniciGirisID",
                table: "KullaniciKisisel",
                column: "KullaniciGirisID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ogun_GunlukRaporID",
                table: "Ogun",
                column: "GunlukRaporID");

            migrationBuilder.CreateIndex(
                name: "IX_Ogun_KullaniciKisiselID",
                table: "Ogun",
                column: "KullaniciKisiselID");

            migrationBuilder.CreateIndex(
                name: "IX_Su_KullaniciKisiselId",
                table: "Su",
                column: "KullaniciKisiselId");

            migrationBuilder.CreateIndex(
                name: "IX_Yemek_KategoriID",
                table: "Yemek",
                column: "KategoriID");

            migrationBuilder.CreateIndex(
                name: "IX_YemekMiktari_YemekID",
                table: "YemekMiktari",
                column: "YemekID");

            migrationBuilder.CreateIndex(
                name: "IX_YemekMiktarOgun_OgunID",
                table: "YemekMiktarOgun",
                column: "OgunID");

            migrationBuilder.CreateIndex(
                name: "IX_YemekMiktarOgun_YemekMiktarID",
                table: "YemekMiktarOgun",
                column: "YemekMiktarID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Su");

            migrationBuilder.DropTable(
                name: "YemekMiktarOgun");

            migrationBuilder.DropTable(
                name: "Ogun");

            migrationBuilder.DropTable(
                name: "YemekMiktari");

            migrationBuilder.DropTable(
                name: "GunlukRapor");

            migrationBuilder.DropTable(
                name: "Yemek");

            migrationBuilder.DropTable(
                name: "KullaniciKisisel");

            migrationBuilder.DropTable(
                name: "Kategori");

            migrationBuilder.DropTable(
                name: "KullaniciGiris");
        }
    }
}
