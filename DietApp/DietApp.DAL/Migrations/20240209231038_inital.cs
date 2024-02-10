using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DietApp.DAL.Migrations
{
    public partial class inital : Migration
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
                    FotografYolu = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    Boy = table.Column<double>(type: "float", nullable: false),
                    Kilo = table.Column<double>(type: "float", nullable: false),
                    HedefKilo = table.Column<double>(type: "float", nullable: false),
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
                    KullaniciKisiselId = table.Column<int>(type: "int", nullable: false),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                values: new object[,]
                {
                    { 1, "Meyve" },
                    { 2, "Bakliyat" },
                    { 3, "HazirYemek" },
                    { 4, "Kahvaltilik" },
                    { 5, "Sebze" }
                });

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
                    { 1, new DateTime(2024, 2, 10, 2, 10, 38, 401, DateTimeKind.Local).AddTicks(7765), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 170.0, false, 3000.0, 70.0, 2000.0, "ahmet", 80.0, 1, "mehmet", 18 },
                    { 2, new DateTime(2024, 2, 10, 2, 10, 38, 401, DateTimeKind.Local).AddTicks(7778), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 170.0, false, 3000.0, 70.0, 2000.0, "ahmet", 80.0, 2, "mehmet", 18 },
                    { 3, new DateTime(2024, 2, 10, 2, 10, 38, 401, DateTimeKind.Local).AddTicks(7780), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 170.0, false, 3000.0, 70.0, 2000.0, "ahmet", 80.0, 3, "mehmet", 18 },
                    { 4, new DateTime(2024, 2, 10, 2, 10, 38, 401, DateTimeKind.Local).AddTicks(7781), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 170.0, false, 3000.0, 70.0, 2000.0, "ahmet", 80.0, 4, "mehmet", 18 },
                    { 5, new DateTime(2024, 2, 10, 2, 10, 38, 401, DateTimeKind.Local).AddTicks(7783), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 170.0, false, 3000.0, 70.0, 2000.0, "admin", 80.0, 5, "adminoğlu", 18 }
                });

            migrationBuilder.InsertData(
                table: "Yemek",
                columns: new[] { "ID", "FotografYolu", "Kalori", "KarbonhidratMiktari", "KategoriID", "ProteinMiktari", "YagMiktari", "YemekAdi" },
                values: new object[,]
                {
                    { 1, "Fotograflar\\Elma.jpg", 95.0, 19.0, 1, 0.29999999999999999, 0.29999999999999999, "Elma" },
                    { 2, "Fotograflar\\BeyazPeynir.jpg", 291.0, 22.0, 4, 3.5, 21.0, "BeyazPeynir" },
                    { 3, "Fotograflar\\BezelyeProteini.jpg", 205.0, 18.5, 2, 33.200000000000003, 3.7999999999999998, "BezelyeProteini" },
                    { 4, "Fotograflar\\SiyezBurguMakarna.jpg", 107.12, 21.940000000000001, 2, 3.04, 0.57999999999999996, "SiyezBurguMakarna " },
                    { 5, "Fotograflar\\Tofu.jpg", 43.399999999999999, 0.29999999999999999, 4, 3.5499999999999998, 3.1200000000000001, "Tofu" },
                    { 6, "Fotograflar\\PortakalliSekersizBitterCikolata.jpg", 563.39999999999998, 52.899999999999999, 3, 6.8200000000000003, 36.07, "PortakalliSekersizBitterCikolata" },
                    { 7, "Fotograflar\\Portakal.jpg", 47.0, 11.800000000000001, 1, 0.90000000000000002, 0.10000000000000001, "Portakal" },
                    { 8, "Fotograflar\\Brokoli.jpg", 39.0, 2.5099999999999998, 5, 3.2999999999999998, 0.20000000000000001, "Brokoli" },
                    { 9, "Fotograflar\\BademSutu.jpg", 24.0, 3.0, 4, 0.5, 1.1000000000000001, "BademSutu" },
                    { 10, "Fotograflar\\Patlican.jpg", 17.0, 2.4900000000000002, 5, 1.24, 0.17999999999999999, "Patlican " },
                    { 11, "Fotograflar\\Hamburger.jpg", 106.38, 16.120000000000001, 3, 4.7300000000000004, 2.4900000000000002, "Hamburger" },
                    { 12, "Fotograflar\\SiyahZeytin.jpg", 208.69999999999999, 1.1000000000000001, 4, 1.8, 2.1000000000000001, "SiyahZeytin" },
                    { 13, "Fotograflar\\Sucuk.jpg", 189.00999999999999, 35.960000000000001, 4, 8.6300000000000008, 1.3799999999999999, "Sucuk" },
                    { 14, "Fotograflar\\Avokado.jpg", 200.0, 8.5299999999999994, 5, 2.0, 14.66, "Avokado" },
                    { 15, "Fotograflar\\Cilek.jpg", 32.0, 7.6799999999999997, 1, 0.67000000000000004, 0.29999999999999999, "Cilek" },
                    { 16, "Fotograflar\\MeyveliYasPasta.jpg", 143.0, 21.530000000000001, 3, 3.5600000000000001, 4.5599999999999996, "MeyveliYasPasta" },
                    { 17, "Fotograflar\\Mantar.jpg", 3.0, 3.2599999999999998, 5, 3.0899999999999999, 0.34000000000000002, "Mantar" },
                    { 18, "Fotograflar\\Havuc.jpg", 41.0, 9.5800000000000001, 5, 0.93000000000000005, 0.23999999999999999, "Havuc" },
                    { 19, "Fotograflar\\Nohut.jpg", 164.0, 27.420000000000002, 2, 8.8599999999999994, 2.5899999999999999, "Nohut" },
                    { 20, "Fotograflar\\IspanakliPizza.jpg", 129.72, 20.57, 3, 3.48, 3.6000000000000001, "IspanakliPizza" }
                });

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
