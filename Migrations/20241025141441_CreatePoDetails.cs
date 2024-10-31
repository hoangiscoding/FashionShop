using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FashionShop.Migrations
{
    public partial class CreateChiTietDonHang : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChiTietDonHang",
                columns: table => new
                {
                    MaChiTietDonHang = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MaDonHang = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MaSP = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SoLuong = table.Column<decimal>(type: "money", nullable: false),
                    Fob = table.Column<decimal>(type: "smallmoney", nullable: false),
                    PrcInBaseCur = table.Column<decimal>(type: "smallmoney", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietDonHang", x => x.MaChiTietDonHang);
                    table.ForeignKey(
                        name: "FK_ChiTietDonHang_DonHang_MaDonHang",
                        column: x => x.MaDonHang,
                        principalTable: "DonHang",
                        principalColumn: "MaDonHang",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietDonHang_SanPham_MaSP",
                        column: x => x.MaSP,
                        principalTable: "SanPham",
                        principalColumn: "MaSP",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietDonHang_MaDonHang",
                table: "ChiTietDonHang",
                column: "MaDonHang");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietDonHang_MaSP",
                table: "ChiTietDonHang",
                column: "MaSP");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChiTietDonHang");
        }
    }
}
//