using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DietApp.DAL.Migrations
{
    public partial class c : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_YemekMiktarOgun_Ogun_OgunID1",
                table: "YemekMiktarOgun");

            migrationBuilder.DropForeignKey(
                name: "FK_YemekMiktarOgun_YemekMiktari_OgunID",
                table: "YemekMiktarOgun");

            migrationBuilder.DropIndex(
                name: "IX_YemekMiktarOgun_OgunID1",
                table: "YemekMiktarOgun");

            migrationBuilder.DropColumn(
                name: "OgunID1",
                table: "YemekMiktarOgun");

            migrationBuilder.UpdateData(
                table: "KullaniciKisisel",
                keyColumn: "ID",
                keyValue: 1,
                column: "BaslangicTarihi",
                value: new DateTime(2024, 2, 7, 21, 16, 58, 260, DateTimeKind.Local).AddTicks(5878));

            migrationBuilder.CreateIndex(
                name: "IX_YemekMiktarOgun_YemekMiktarID",
                table: "YemekMiktarOgun",
                column: "YemekMiktarID");

            migrationBuilder.AddForeignKey(
                name: "FK_YemekMiktarOgun_Ogun_OgunID",
                table: "YemekMiktarOgun",
                column: "OgunID",
                principalTable: "Ogun",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_YemekMiktarOgun_YemekMiktari_YemekMiktarID",
                table: "YemekMiktarOgun",
                column: "YemekMiktarID",
                principalTable: "YemekMiktari",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_YemekMiktarOgun_Ogun_OgunID",
                table: "YemekMiktarOgun");

            migrationBuilder.DropForeignKey(
                name: "FK_YemekMiktarOgun_YemekMiktari_YemekMiktarID",
                table: "YemekMiktarOgun");

            migrationBuilder.DropIndex(
                name: "IX_YemekMiktarOgun_YemekMiktarID",
                table: "YemekMiktarOgun");

            migrationBuilder.AddColumn<int>(
                name: "OgunID1",
                table: "YemekMiktarOgun",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "KullaniciKisisel",
                keyColumn: "ID",
                keyValue: 1,
                column: "BaslangicTarihi",
                value: new DateTime(2024, 2, 7, 21, 15, 33, 940, DateTimeKind.Local).AddTicks(1263));

            migrationBuilder.CreateIndex(
                name: "IX_YemekMiktarOgun_OgunID1",
                table: "YemekMiktarOgun",
                column: "OgunID1");

            migrationBuilder.AddForeignKey(
                name: "FK_YemekMiktarOgun_Ogun_OgunID1",
                table: "YemekMiktarOgun",
                column: "OgunID1",
                principalTable: "Ogun",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_YemekMiktarOgun_YemekMiktari_OgunID",
                table: "YemekMiktarOgun",
                column: "OgunID",
                principalTable: "YemekMiktari",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
