using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FashionShop.Migrations
{
    public partial class AddSelfForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MaTraoDoiTienTe",
                table: "TienTe",
                type: "nvarchar(50)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TienTe_MaTraoDoiTienTe",
                table: "TienTe",
                column: "MaTraoDoiTienTe");

            migrationBuilder.AddForeignKey(
                name: "FK_TienTe_TienTe_MaTraoDoiTienTe",
                table: "TienTe",
                column: "MaTraoDoiTienTe",
                principalTable: "TienTe",
                principalColumn: "MaTraoDoiTienTe");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TienTe_TienTe_MaTraoDoiTienTe",
                table: "TienTe");

            migrationBuilder.DropIndex(
                name: "IX_TienTe_MaTraoDoiTienTe",
                table: "TienTe");

            migrationBuilder.DropColumn(
                name: "MaTraoDoiTienTe",
                table: "TienTe");
        }
    }
}
//