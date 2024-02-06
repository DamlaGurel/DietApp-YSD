using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DietApp.DAL.Migrations
{
    public partial class tablodeneme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OgunKullanici");

            migrationBuilder.DropTable(
                name: "YemekOgun");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OgunKullanici",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciID = table.Column<int>(type: "int", nullable: false),
                    OgunID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OgunKullanici", x => x.ID);
                    table.ForeignKey(
                        name: "FK_OgunKullanici_BesinDegeri_OgunID",
                        column: x => x.OgunID,
                        principalTable: "BesinDegeri",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OgunKullanici_KullaniciKisisel_KullaniciID",
                        column: x => x.KullaniciID,
                        principalTable: "KullaniciKisisel",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "YemekOgun",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OgunID = table.Column<int>(type: "int", nullable: false),
                    YemekID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YemekOgun", x => x.ID);
                    table.ForeignKey(
                        name: "FK_YemekOgun_BesinDegeri_OgunID",
                        column: x => x.OgunID,
                        principalTable: "BesinDegeri",
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
                name: "IX_OgunKullanici_KullaniciID",
                table: "OgunKullanici",
                column: "KullaniciID");

            migrationBuilder.CreateIndex(
                name: "IX_OgunKullanici_OgunID",
                table: "OgunKullanici",
                column: "OgunID");

            migrationBuilder.CreateIndex(
                name: "IX_YemekOgun_OgunID",
                table: "YemekOgun",
                column: "OgunID");

            migrationBuilder.CreateIndex(
                name: "IX_YemekOgun_YemekID",
                table: "YemekOgun",
                column: "YemekID");
        }
    }
}
