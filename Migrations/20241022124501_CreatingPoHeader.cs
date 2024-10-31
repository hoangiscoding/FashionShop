using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FashionShop.Migrations
{
    public partial class CreatingDonHang : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DonHang",
                columns: table => new
                {
                    MaDonHang = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime", nullable: false),
                    MaNCC = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MaTienTeCoSo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MaTienTeDonHang = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TyGiaHoiDoai = table.Column<decimal>(type: "smallmoney", nullable: false),
                    GiamGia = table.Column<int>(type: "int", nullable: false),
                    MaBaoGia = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NgayBaoGia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DieuKhoanThanhToan = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonHang", x => x.MaDonHang);
                    table.ForeignKey(
                        name: "FK_DonHang_TienTe_MaTienTeCoSo",
                        column: x => x.MaTienTeCoSo,
                        principalTable: "TienTe",
                        principalColumn: "MaTienTeCoSo",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_DonHang_TienTe_MaTienTeDonHang",
                        column: x => x.MaTienTeDonHang,
                        principalTable: "TienTe",
                        principalColumn: "MaTienTeDonHang",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_DonHang_NhaCungCap_MaNCC",
                        column: x => x.MaNCC,
                        principalTable: "NhaCungCap",
                        principalColumn: "MaNCC",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DonHang_MaTienTeCoSo",
                table: "DonHang",
                column: "MaTienTeCoSo");

            migrationBuilder.CreateIndex(
                name: "IX_DonHang_MaTienTeDonHang",
                table: "DonHang",
                column: "MaTienTeDonHang");

            migrationBuilder.CreateIndex(
                name: "IX_DonHang_MaNCC",
                table: "DonHang",
                column: "MaNCC");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DonHang");
        }
    }
}
//