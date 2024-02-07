using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DietApp.DAL.Migrations
{
    public partial class tgyjk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "KullaniciKisisel",
                keyColumn: "ID",
                keyValue: 1,
                column: "BaslangicTarihi",
                value: new DateTime(2024, 2, 7, 10, 42, 15, 876, DateTimeKind.Local).AddTicks(6963));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "KullaniciKisisel",
                keyColumn: "ID",
                keyValue: 1,
                column: "BaslangicTarihi",
                value: new DateTime(2024, 2, 7, 10, 41, 48, 267, DateTimeKind.Local).AddTicks(2449));
        }
    }
}
