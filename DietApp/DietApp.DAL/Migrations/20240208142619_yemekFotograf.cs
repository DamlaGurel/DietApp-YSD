using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DietApp.DAL.Migrations
{
    public partial class yemekFotograf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FotografYolu",
                table: "Yemek",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "KullaniciKisisel",
                keyColumn: "ID",
                keyValue: 1,
                column: "BaslangicTarihi",
                value: new DateTime(2024, 2, 8, 17, 26, 18, 896, DateTimeKind.Local).AddTicks(5622));

            migrationBuilder.UpdateData(
                table: "KullaniciKisisel",
                keyColumn: "ID",
                keyValue: 2,
                column: "BaslangicTarihi",
                value: new DateTime(2024, 2, 8, 17, 26, 18, 896, DateTimeKind.Local).AddTicks(5631));

            migrationBuilder.UpdateData(
                table: "KullaniciKisisel",
                keyColumn: "ID",
                keyValue: 3,
                column: "BaslangicTarihi",
                value: new DateTime(2024, 2, 8, 17, 26, 18, 896, DateTimeKind.Local).AddTicks(5633));

            migrationBuilder.UpdateData(
                table: "KullaniciKisisel",
                keyColumn: "ID",
                keyValue: 4,
                column: "BaslangicTarihi",
                value: new DateTime(2024, 2, 8, 17, 26, 18, 896, DateTimeKind.Local).AddTicks(5634));

            migrationBuilder.UpdateData(
                table: "KullaniciKisisel",
                keyColumn: "ID",
                keyValue: 5,
                column: "BaslangicTarihi",
                value: new DateTime(2024, 2, 8, 17, 26, 18, 896, DateTimeKind.Local).AddTicks(5636));

            migrationBuilder.UpdateData(
                table: "Yemek",
                keyColumn: "ID",
                keyValue: 1,
                column: "FotografYolu",
                value: "Fotograflar\\Elma.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FotografYolu",
                table: "Yemek");

            migrationBuilder.UpdateData(
                table: "KullaniciKisisel",
                keyColumn: "ID",
                keyValue: 1,
                column: "BaslangicTarihi",
                value: new DateTime(2024, 2, 8, 15, 53, 20, 31, DateTimeKind.Local).AddTicks(5409));

            migrationBuilder.UpdateData(
                table: "KullaniciKisisel",
                keyColumn: "ID",
                keyValue: 2,
                column: "BaslangicTarihi",
                value: new DateTime(2024, 2, 8, 15, 53, 20, 31, DateTimeKind.Local).AddTicks(5421));

            migrationBuilder.UpdateData(
                table: "KullaniciKisisel",
                keyColumn: "ID",
                keyValue: 3,
                column: "BaslangicTarihi",
                value: new DateTime(2024, 2, 8, 15, 53, 20, 31, DateTimeKind.Local).AddTicks(5422));

            migrationBuilder.UpdateData(
                table: "KullaniciKisisel",
                keyColumn: "ID",
                keyValue: 4,
                column: "BaslangicTarihi",
                value: new DateTime(2024, 2, 8, 15, 53, 20, 31, DateTimeKind.Local).AddTicks(5424));

            migrationBuilder.UpdateData(
                table: "KullaniciKisisel",
                keyColumn: "ID",
                keyValue: 5,
                column: "BaslangicTarihi",
                value: new DateTime(2024, 2, 8, 15, 53, 20, 31, DateTimeKind.Local).AddTicks(5425));
        }
    }
}
