using Microsoft.EntityFrameworkCore.Migrations;

namespace FashionShop.Migrations
{
    public partial class AddSupplierTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NhaCungCap",
                columns: table => new
                {
                    MaNCC = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TenNCC = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    DiaChi= table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: true),
                    SDT = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhaCungCap", x => x.MaNCC);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NhaCungCap");
        }
    }
}
//