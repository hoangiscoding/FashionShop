using Microsoft.EntityFrameworkCore.Migrations;

namespace FashionShop.Migrations
{
    public partial class AddedProductPhoto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Anh",
                table: "SanPham",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Anh",
                table: "SanPham");
        }
    }
}
//