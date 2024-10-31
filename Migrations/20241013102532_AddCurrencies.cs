using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FashionShop.Migrations
{
    public partial class AddTienTe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TienTe",
                columns: table => new
                {
                    MaTienTe = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TenTienTe = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TyGiaHoiDoai = table.Column<decimal>(type: "money", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TienTe", x => x.MaTienTe);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TienTe");
        }
    }
}
//