using Microsoft.EntityFrameworkCore.Migrations;

namespace FashionShop.Migrations
{
    public partial class AddedMaThuongHieuToProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MaThuongHieu",
                table: "SanPham",
                type: "nvarchar(50)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_MaThuongHieu",
                table: "SanPham",
                column: "MaThuongHieu");

            migrationBuilder.AddForeignKey(
                name: "FK_SanPham_ThuongHieu_MaThuongHieu",
                table: "SanPham",
                column: "MaThuongHieu",
                principalTable: "ThuongHieu",
                principalColumn: "MaThuongHieu",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SanPham_ThuongHieu_MaThuongHieu",
                table: "SanPham");

            migrationBuilder.DropIndex(
                name: "IX_SanPham_MaThuongHieu",
                table: "SanPham");

            migrationBuilder.DropColumn(
                name: "MaThuongHieu",
                table: "SanPham");
        }
    }
}
//