using Microsoft.EntityFrameworkCore.Migrations;

namespace FashionShop.Migrations
{
    public partial class AddedMaDanhMucToProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MaDanhMuc",
                table: "SanPham",
                type: "nvarchar(50)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_MaDanhMuc",
                table: "SanPham",
                column: "MaDanhMuc");

            migrationBuilder.AddForeignKey(
                name: "FK_SanPham_DanhMuc_MaDanhMuc",
                table: "SanPham",
                column: "MaDanhMuc",
                principalTable: "DanhMuc",
                principalColumn: "MaDanhMuc",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SanPham_DanhMuc_MaDanhMuc",
                table: "SanPham");

            migrationBuilder.DropIndex(
                name: "IX_SanPham_MaDanhMuc",
                table: "SanPham");

            migrationBuilder.DropColumn(
                name: "MaDanhMuc",
                table: "SanPham");
        }
    }
}
//