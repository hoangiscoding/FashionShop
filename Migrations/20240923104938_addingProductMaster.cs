using Microsoft.EntityFrameworkCore.Migrations;

namespace FashionShop.Migrations
{
    public partial class addingProductMaster : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SanPham",
                columns: table => new
                {
                    MaSP = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TenSP = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    DonGiaNhap = table.Column<decimal>(type: "money", nullable: false),
                    DonGiaBan = table.Column<decimal>(type: "money", nullable: false),
                    MaDonVi = table.Column<int>(type: "int", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPham", x => x.MaSP);
                    table.ForeignKey(
                        name: "FK_SanPham_DonVi_MaDonVi",
                        column: x => x.MaDonVi,
                        principalTable: "DonVi",
                        principalColumn: "MaDonVi",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_MaDonVi",
                table: "SanPham",
                column: "MaDonVi");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SanPham");
        }
    }
}
//