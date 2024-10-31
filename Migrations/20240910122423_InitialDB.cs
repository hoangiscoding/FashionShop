using Microsoft.EntityFrameworkCore.Migrations;

namespace FashionShop.Migrations
{
    public partial class InitialDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DonVi",
                columns: table => new
                {
                    MaDonVi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TenDonVi = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonVi", x => x.MaDonVi);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DonVi");
        }
    }
}
//