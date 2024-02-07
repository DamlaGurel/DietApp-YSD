using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DietApp.DAL.Migrations
{
    public partial class tgyjkk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "KullaniciGiris",
                columns: new[] { "ID", "KullaniciAdi", "KullaniciKisiselID", "Sifre" },
                values: new object[,]
                {
                    { 1, "YalinTuzmen", null, "A665A45920422F9D417E4867EFDC4FB8A04A1F3FFF1FA07E998E86F7F7A27AE3" },
                    { 2, "SilaYildirim", null, "A665A45920422F9D417E4867EFDC4FB8A04A1F3FFF1FA07E998E86F7F7A27AE3" },
                    { 3, "DamlaGurel", null, "A665A45920422F9D417E4867EFDC4FB8A04A1F3FFF1FA07E998E86F7F7A27AE3" },
                    { 4, "admin", null, "admin" }
                });

            migrationBuilder.UpdateData(
                table: "KullaniciKisisel",
                keyColumn: "ID",
                keyValue: 1,
                column: "BaslangicTarihi",
                value: new DateTime(2024, 2, 7, 10, 42, 30, 670, DateTimeKind.Local).AddTicks(6992));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "KullaniciGiris",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "KullaniciGiris",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "KullaniciGiris",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "KullaniciGiris",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "KullaniciKisisel",
                keyColumn: "ID",
                keyValue: 1,
                column: "BaslangicTarihi",
                value: new DateTime(2024, 2, 7, 10, 42, 15, 876, DateTimeKind.Local).AddTicks(6963));
        }
    }
}
