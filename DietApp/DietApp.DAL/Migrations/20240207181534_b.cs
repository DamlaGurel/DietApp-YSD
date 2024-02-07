using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DietApp.DAL.Migrations
{
    public partial class b : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "KullaniciKisisel",
                keyColumn: "ID",
                keyValue: 1,
                column: "BaslangicTarihi",
                value: new DateTime(2024, 2, 7, 21, 15, 33, 940, DateTimeKind.Local).AddTicks(1263));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "KullaniciKisisel",
                keyColumn: "ID",
                keyValue: 1,
                column: "BaslangicTarihi",
                value: new DateTime(2024, 2, 7, 21, 12, 1, 242, DateTimeKind.Local).AddTicks(8429));
        }
    }
}
