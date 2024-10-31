using Microsoft.EntityFrameworkCore.Migrations;

namespace FashionShop.Migrations
{
    public partial class AddingOtherProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MaNhomSP",
                table: "SanPham",
                type: "nvarchar(50)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MaHoSoSP",
                table: "SanPham",
                type: "nvarchar(50)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_MaNhomSP",
                table: "SanPham",
                column: "MaNhomSP");

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_MaHoSoSP",
                table: "SanPham",
                column: "MaHoSoSP");

            migrationBuilder.AddForeignKey(
                name: "FK_SanPham_NhomSP_MaNhomSP",
                table: "SanPham",
                column: "MaNhomSP",
                principalTable: "NhomSP",
                principalColumn: "MaNhomSP",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SanPham_HoSoSP_MaHoSoSP",
                table: "SanPham",
                column: "MaHoSoSP",
                principalTable: "HoSoSP",
                principalColumn: "MaHoSoSP",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SanPham_NhomSP_MaNhomSP",
                table: "SanPham");

            migrationBuilder.DropForeignKey(
                name: "FK_SanPham_HoSoSP_MaHoSoSP",
                table: "SanPham");

            migrationBuilder.DropIndex(
                name: "IX_SanPham_MaNhomSP",
                table: "SanPham");

            migrationBuilder.DropIndex(
                name: "IX_SanPham_MaHoSoSP",
                table: "SanPham");

            migrationBuilder.DropColumn(
                name: "MaNhomSP",
                table: "SanPham");

            migrationBuilder.DropColumn(
                name: "MaHoSoSP",
                table: "SanPham");
        }
    }
}
//