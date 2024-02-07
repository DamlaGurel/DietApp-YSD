﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DietApp.DAL.Migrations
{
<<<<<<<< HEAD:DietApp/DietApp.DAL/Migrations/20240207104935_tgyjkk.cs
    public partial class tgyjkk : Migration
========
    public partial class initial : Migration
>>>>>>>> origin/sila:DietApp/DietApp.DAL/Migrations/20240207103924_initial.cs
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
                    BitisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KullaniciKisisel", x => x.ID);
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
                name: "KullaniciGiris",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sifre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KullaniciKisiselID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KullaniciGiris", x => x.ID);
                    table.ForeignKey(
                        name: "FK_KullaniciGiris_KullaniciKisisel_KullaniciKisiselID",
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
                name: "KullaniciKisiselOgun",
                columns: table => new
                {
                    KullanicilarinOgunleriID = table.Column<int>(type: "int", nullable: false),
                    OgunlerinKullanicilariID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KullaniciKisiselOgun", x => new { x.KullanicilarinOgunleriID, x.OgunlerinKullanicilariID });
                    table.ForeignKey(
                        name: "FK_KullaniciKisiselOgun_KullaniciKisisel_OgunlerinKullanicilariID",
                        column: x => x.OgunlerinKullanicilariID,
                        principalTable: "KullaniciKisisel",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KullaniciKisiselOgun_Ogun_KullanicilarinOgunleriID",
                        column: x => x.KullanicilarinOgunleriID,
                        principalTable: "Ogun",
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
                name: "YemekMiktarOgun",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YemekMiktarID = table.Column<int>(type: "int", nullable: false),
                    OgunID = table.Column<int>(type: "int", nullable: false),
                    OgunID1 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YemekMiktarOgun", x => x.ID);
                    table.ForeignKey(
                        name: "FK_YemekMiktarOgun_Ogun_OgunID1",
                        column: x => x.OgunID1,
                        principalTable: "Ogun",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_YemekMiktarOgun_YemekMiktari_OgunID",
                        column: x => x.OgunID,
                        principalTable: "YemekMiktari",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
<<<<<<<< HEAD:DietApp/DietApp.DAL/Migrations/20240207104935_tgyjkk.cs
                table: "KullaniciGiris",
                columns: new[] { "ID", "KullaniciAdi", "KullaniciKisiselID", "Sifre" },
                values: new object[,]
                {
                    { 1, "YalinTuzmen", null, "A665A45920422F9D417E4867EFDC4FB8A04A1F3FFF1FA07E998E86F7F7A27AE3" },
                    { 2, "SilaYildirim", null, "A665A45920422F9D417E4867EFDC4FB8A04A1F3FFF1FA07E998E86F7F7A27AE3" },
                    { 3, "DamlaGurel", null, "A665A45920422F9D417E4867EFDC4FB8A04A1F3FFF1FA07E998E86F7F7A27AE3" },
                    { 4, "admin", null, "8C6976E5B5410415BDE908BD4DEE15DFB167A9C873FC4BB8A81F6F2AB448A918" }
                });

            migrationBuilder.InsertData(
                table: "KullaniciKisisel",
                columns: new[] { "ID", "BaslangicTarihi", "BitisTarihi", "Boy", "Cinsiyet", "GunlukKalori", "HedefKilo", "Isim", "Kilo", "Soyisim", "SuMiktari", "Yas" },
                values: new object[] { 1, new DateTime(2024, 2, 7, 13, 49, 35, 47, DateTimeKind.Local).AddTicks(6034), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 170m, false, 3000.0, 70m, "ahmet", 80m, "mehmet", 0.0, 18 });
========
                table: "Kategori",
                columns: new[] { "ID", "KategoriAdi" },
                values: new object[] { 1, "Meyve" });

            migrationBuilder.InsertData(
                table: "KullaniciKisisel",
                columns: new[] { "ID", "BaslangicTarihi", "BitisTarihi", "Boy", "Cinsiyet", "GunlukKalori", "HedefKilo", "HedefSuMiktari", "Isim", "Kilo", "Soyisim", "Yas" },
                values: new object[] { 1, new DateTime(2024, 2, 7, 13, 39, 23, 840, DateTimeKind.Local).AddTicks(9720), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 170m, false, 3000.0, 70m, 2000.0, "ahmet", 80m, "mehmet", 18 });

            migrationBuilder.InsertData(
                table: "Yemek",
                columns: new[] { "ID", "Kalori", "KarbonhidratMiktari", "KategoriID", "ProteinMiktari", "YagMiktari", "YemekAdi" },
                values: new object[] { 1, 95.0, 19.0, 1, 0.29999999999999999, 0.29999999999999999, "Elma" });
>>>>>>>> origin/sila:DietApp/DietApp.DAL/Migrations/20240207103924_initial.cs

            migrationBuilder.CreateIndex(
                name: "IX_GunlukRapor_KullaniciKisiselID",
                table: "GunlukRapor",
                column: "KullaniciKisiselID");

            migrationBuilder.CreateIndex(
                name: "IX_KullaniciGiris_KullaniciKisiselID",
                table: "KullaniciGiris",
                column: "KullaniciKisiselID",
                unique: true,
                filter: "[KullaniciKisiselID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_KullaniciKisiselOgun_OgunlerinKullanicilariID",
                table: "KullaniciKisiselOgun",
                column: "OgunlerinKullanicilariID");

            migrationBuilder.CreateIndex(
                name: "IX_Su_KullaniciKisiselId",
                table: "Su",
                column: "KullaniciKisiselId");

            migrationBuilder.CreateIndex(
                name: "IX_Yemek_KategoriID",
                table: "Yemek",
                column: "KategoriID");

            migrationBuilder.CreateIndex(
                name: "IX_YemekMiktari_YenilenYemekID",
                table: "YemekMiktari",
                column: "YenilenYemekID");

            migrationBuilder.CreateIndex(
                name: "IX_YemekMiktarOgun_OgunID",
                table: "YemekMiktarOgun",
                column: "OgunID");

            migrationBuilder.CreateIndex(
                name: "IX_YemekMiktarOgun_OgunID1",
                table: "YemekMiktarOgun",
                column: "OgunID1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GunlukRapor");

            migrationBuilder.DropTable(
                name: "KullaniciGiris");

            migrationBuilder.DropTable(
                name: "KullaniciKisiselOgun");

            migrationBuilder.DropTable(
                name: "Su");

            migrationBuilder.DropTable(
                name: "YemekMiktarOgun");

            migrationBuilder.DropTable(
                name: "KullaniciKisisel");

            migrationBuilder.DropTable(
                name: "Ogun");

            migrationBuilder.DropTable(
                name: "YemekMiktari");

            migrationBuilder.DropTable(
                name: "Yemek");

            migrationBuilder.DropTable(
                name: "Kategori");
        }
    }
}
