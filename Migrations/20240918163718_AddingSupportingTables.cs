using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FashionShop.Migrations
{
    public partial class AddingSupportingTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
          

            migrationBuilder.CreateTable(
                name: "ThuongHieu",
                columns: table => new
                {
                    MaThuongHieu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TenThuongHieu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThuongHieu", x => x.MaThuongHieu);
                });

            migrationBuilder.CreateTable(
                name: "DanhMuc",
                columns: table => new
                {
                    MaDanhMuc = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TenDanhMuc = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhMuc", x => x.MaDanhMuc);
                });

            migrationBuilder.CreateTable(
                name: "NhomSP",
                columns: table => new
                {
                    MaNhomSP = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TenNhom = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhomSP", x => x.MaNhomSP);
                });

            migrationBuilder.CreateTable(
                name: "HoSoSP",
                columns: table => new
                {
                    MaHoSoSP = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TenHoSoSP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoSoSP", x => x.MaHoSoSP);
                });                                                            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QuyenVaiTro");

            migrationBuilder.DropTable(
                name: "QuyenNguoiDung");

            migrationBuilder.DropTable(
                name: "ThongTinDangNhap");

            migrationBuilder.DropTable(
                name: "VaiTroNguoiDung");

            migrationBuilder.DropTable(
                name: "TokenNguoiDung");

            migrationBuilder.DropTable(
                name: "ThuongHieu");

            migrationBuilder.DropTable(
                name: "DanhMuc");

            migrationBuilder.DropTable(
                name: "NhomSP");

            migrationBuilder.DropTable(
                name: "HoSoSP");

            migrationBuilder.DropTable(
                name: "DonVi");

            migrationBuilder.DropTable(
                name: "VaiTro");

            migrationBuilder.DropTable(
                name: "NguoiDung");
        }
    }
}
//