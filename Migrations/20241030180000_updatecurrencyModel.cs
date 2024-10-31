using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FashionShop.Migrations
{
    public partial class updatecurrencyModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuyenNguoiDung_NguoiDung_MaNguoiDung",
                table: "QuyenNguoiDung");

            migrationBuilder.DropForeignKey(
                name: "FK_QuyenVaiTro_VaiTro_MaVaiTro",
                table: "QuyenVaiTro");

            migrationBuilder.DropForeignKey(
                name: "FK_SanPham_HoSoSP_MaHoSoSP",
                table: "SanPham");

            migrationBuilder.DropForeignKey(
                name: "FK_ThongTinDangNhap_NguoiDung_MaNguoiDung",
                table: "ThongTinDangNhap");

            migrationBuilder.DropForeignKey(
                name: "FK_TokenNguoiDung_NguoiDung_MaNguoiDung",
                table: "TokenNguoiDung");

            migrationBuilder.DropForeignKey(
                name: "FK_VaiTroNguoiDung_NguoiDung_MaNguoiDung",
                table: "VaiTroNguoiDung");

            migrationBuilder.DropForeignKey(
                name: "FK_VaiTroNguoiDung_VaiTro_MaVaiTro",
                table: "VaiTroNguoiDung");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_HoSoSP_MaHoSoSP",
                table: "HoSoSP");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VaiTroNguoiDung",
                table: "VaiTroNguoiDung");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VaiTro",
                table: "VaiTro");

            migrationBuilder.DropIndex(
                name: "TenVaiTroIndex",
                table: "VaiTro");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TokenNguoiDung",
                table: "TokenNguoiDung");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ThongTinDangNhap",
                table: "ThongTinDangNhap");

            migrationBuilder.DropPrimaryKey(
                name: "PK_QuyenVaiTro",
                table: "QuyenVaiTro");

            migrationBuilder.DropPrimaryKey(
                name: "PK_QuyenNguoiDung",
                table: "QuyenNguoiDung");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NguoiDung",
                table: "NguoiDung");

            migrationBuilder.DropIndex(
                name: "TenNguoiDungIndex",
                table: "NguoiDung");

            migrationBuilder.DropColumn(
                name: "MaHoSoSP",
                table: "HoSoSP");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "VaiTroNguoiDung",
                newName: "VaiTroNguoiDung");

            migrationBuilder.RenameTable(
                name: "VaiTro",
                newName: "VaiTro");

            migrationBuilder.RenameTable(
                name: "TokenNguoiDung",
                newName: "TokenNguoiDung");

            migrationBuilder.RenameTable(
                name: "ThongTinDangNhap",
                newName: "ThongTinDangNhap");

            migrationBuilder.RenameTable(
                name: "QuyenVaiTro",
                newName: "QuyenVaiTro");

            migrationBuilder.RenameTable(
                name: "QuyenNguoiDung",
                newName: "QuyenNguoiDung");

            migrationBuilder.RenameTable(
                name: "NguoiDung",
                newName: "NguoiDung");

            migrationBuilder.RenameColumn(
                name: "MaVaiTro",
                table: "VaiTroNguoiDung",
                newName: "MaVaiTro");

            migrationBuilder.RenameColumn(
                name: "MaNguoiDung",
                table: "VaiTroNguoiDung",
                newName: "MaNguoiDung");

            migrationBuilder.RenameIndex(
                name: "IX_VaiTroNguoiDung_MaVaiTro",
                table: "VaiTroNguoiDung",
                newName: "IX_VaiTroNguoiDung_MaVaiTro");

            migrationBuilder.RenameColumn(
                name: "TenChuanHoa",
                table: "VaiTro",
                newName: "TenChuanHoa");

            migrationBuilder.RenameColumn(
                name: "NCCDangNhap",
                table: "TokenNguoiDung",
                newName: "NCCDangNhap");

            migrationBuilder.RenameColumn(
                name: "MaNguoiDung",
                table: "TokenNguoiDung",
                newName: "MaNguoiDung");

            migrationBuilder.RenameColumn(
                name: "TenNCCDichVu",
                table: "ThongTinDangNhap",
                newName: "TenNCCDichVu");

            migrationBuilder.RenameColumn(
                name: "MaNguoiDung",
                table: "ThongTinDangNhap",
                newName: "MaNguoiDung");

            migrationBuilder.RenameColumn(
                name: "KhoaNCC",
                table: "ThongTinDangNhap",
                newName: "KhoaNCC");

            migrationBuilder.RenameColumn(
                name: "NCCDangNhap",
                table: "ThongTinDangNhap",
                newName: "NCCDangNhap");

            migrationBuilder.RenameIndex(
                name: "IX_ThongTinDangNhap_MaNguoiDung",
                table: "ThongTinDangNhap",
                newName: "IX_ThongTinDangNhap_MaNguoiDung");

            migrationBuilder.RenameColumn(
                name: "MaVaiTro",
                table: "QuyenVaiTro",
                newName: "MaVaiTro");

            migrationBuilder.RenameColumn(
                name: "LoaiQuyen",
                table: "QuyenVaiTro",
                newName: "GiaTriQuyen");

            migrationBuilder.RenameColumn(
                name: "GiaTriQuyen",
                table: "QuyenVaiTro",
                newName: "LoaiQuyen");

            migrationBuilder.RenameIndex(
                name: "IX_QuyenVaiTro_MaVaiTro",
                table: "QuyenVaiTro",
                newName: "IX_QuyenVaiTro_MaVaiTro");

            migrationBuilder.RenameColumn(
                name: "MaNguoiDung",
                table: "QuyenNguoiDung",
                newName: "MaNguoiDung");

            migrationBuilder.RenameColumn(
                name: "LoaiQuyen",
                table: "QuyenNguoiDung",
                newName: "GiaTriQuyen");

            migrationBuilder.RenameColumn(
                name: "GiaTriQuyen",
                table: "QuyenNguoiDung",
                newName: "LoaiQuyen");

            migrationBuilder.RenameIndex(
                name: "IX_QuyenNguoiDung_MaNguoiDung",
                table: "QuyenNguoiDung",
                newName: "IX_QuyenNguoiDung_MaNguoiDung");

            migrationBuilder.RenameColumn(
                name: "TenChuanHoa",
                table: "NguoiDung",
                newName: "TenChuanHoa");

            migrationBuilder.RenameColumn(
                name: "EmailChuanHoa",
                table: "NguoiDung",
                newName: "EmailChuanHoa");

            migrationBuilder.AlterColumn<string>(
                name: "MaTraoDoiTienTe",
                table: "TienTe",
                type: "nvarchar(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MaTienTe",
                table: "TienTe",
                type: "nvarchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)");

            migrationBuilder.AlterColumn<string>(
                name: "MaThuongHieu",
                table: "ThuongHieu",
                type: "nvarchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)");

            migrationBuilder.AlterColumn<string>(
                name: "MaThuongHieu",
                table: "SanPham",
                type: "nvarchar(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MaNhomSP",
                table: "SanPham",
                type: "nvarchar(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MaHoSoSP",
                table: "SanPham",
                type: "nvarchar(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MaDonVi",
                table: "SanPham",
                type: "nvarchar(50)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MaDanhMuc",
                table: "SanPham",
                type: "nvarchar(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MoTa",
                table: "NhomSP",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "MaNhomSP",
                table: "NhomSP",
                type: "nvarchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)");

            migrationBuilder.AlterColumn<string>(
                name: "MaNCC",
                table: "NhaCungCap",
                type: "nvarchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)");

            migrationBuilder.AlterColumn<string>(
                name: "MaHoSoSP",
                table: "HoSoSP",
                type: "nvarchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)");

            migrationBuilder.AlterColumn<string>(
                name: "MaDonVi",
                table: "DonVi",
                type: "nvarchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayTao",
                table: "DonHang",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.AlterColumn<string>(
                name: "MaTienTeDonHang",
                table: "DonHang",
                type: "nvarchar(50)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MaTienTeCoSo",
                table: "DonHang",
                type: "nvarchar(50)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MaNCC",
                table: "DonHang",
                type: "nvarchar(50)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MaDonHang",
                table: "DonHang",
                type: "nvarchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "MaDanhMuc",
                table: "DanhMuc",
                type: "nvarchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)");

            migrationBuilder.AlterColumn<string>(
                name: "MaDonHang",
                table: "ChiTietDonHang",
                type: "nvarchar(50)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MaChiTietDonHang",
                table: "ChiTietDonHang",
                type: "nvarchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VaiTroNguoiDung",
                table: "VaiTroNguoiDung",
                columns: new[] { "MaNguoiDung", "MaVaiTro" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_VaiTro",
                table: "VaiTro",
                column: "MaVaiTro");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TokenNguoiDung",
                table: "TokenNguoiDung",
                columns: new[] { "MaNguoiDung", "NCCDangNhap", "TenToken" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ThongTinDangNhap",
                table: "ThongTinDangNhap",
                columns: new[] { "NCCDangNhap", "KhoaNCC" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_QuyenVaiTro",
                table: "QuyenVaiTro",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_QuyenNguoiDung",
                table: "QuyenNguoiDung",
                column: "MaQuyen");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NguoiDung",
                table: "NguoiDung",
                column: "MaNguoiDung");

            migrationBuilder.CreateIndex(
                name: "TenVaiTroIndex",
                table: "VaiTro",
                column: "TenChuanHoa",
                unique: true,
                filter: "[TenChuanHoa] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "TenNguoiDungIndex",
                table: "NguoiDung",
                column: "TenChuanHoa",
                unique: true,
                filter: "[TenChuanHoa] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_QuyenVaiTro_VaiTro_MaVaiTro",
                table: "QuyenVaiTro",
                column: "MaVaiTro",
                principalTable: "VaiTro",
                principalColumn: "MaVaiTro",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_QuyenNguoiDung_NguoiDung_MaNguoiDung",
                table: "QuyenNguoiDung",
                column: "MaNguoiDung",
                principalTable: "NguoiDung",
                principalColumn: "MaNguoiDung",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ThongTinDangNhap_NguoiDung_MaNguoiDung",
                table: "ThongTinDangNhap",
                column: "MaNguoiDung",
                principalTable: "NguoiDung",
                principalColumn: "MaNguoiDung",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VaiTroNguoiDung_VaiTro_MaVaiTro",
                table: "VaiTroNguoiDung",
                column: "MaVaiTro",
                principalTable: "VaiTro",
                principalColumn: "MaVaiTro",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VaiTroNguoiDung_NguoiDung_MaNguoiDung",
                table: "VaiTroNguoiDung",
                column: "MaNguoiDung",
                principalTable: "NguoiDung",
                principalColumn: "MaNguoiDung",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TokenNguoiDung_NguoiDung_MaNguoiDung",
                table: "TokenNguoiDung",
                column: "MaNguoiDung",
                principalTable: "NguoiDung",
                principalColumn: "MaNguoiDung",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SanPham_HoSoSP_MaHoSoSP",
                table: "SanPham",
                column: "MaHoSoSP",
                principalTable: "HoSoSP",
                principalColumn: "MaHoSoSP");
        

            migrationBuilder.DropForeignKey(
                name: "FK_QuyenVaiTro_VaiTro_MaVaiTro",
                table: "QuyenVaiTro");

            migrationBuilder.DropForeignKey(
                name: "FK_QuyenNguoiDung_NguoiDung_MaNguoiDung",
                table: "QuyenNguoiDung");

            migrationBuilder.DropForeignKey(
                name: "FK_ThongTinDangNhap_NguoiDung_MaNguoiDung",
                table: "ThongTinDangNhap");

            migrationBuilder.DropForeignKey(
                name: "FK_VaiTroNguoiDung_VaiTro_MaVaiTro",
                table: "VaiTroNguoiDung");

            migrationBuilder.DropForeignKey(
                name: "FK_VaiTroNguoiDung_NguoiDung_MaNguoiDung",
                table: "VaiTroNguoiDung");

            migrationBuilder.DropForeignKey(
                name: "FK_TokenNguoiDung_NguoiDung_MaNguoiDung",
                table: "TokenNguoiDung");

            migrationBuilder.DropForeignKey(
                name: "FK_SanPham_HoSoSP_MaHoSoSP",
                table: "SanPham");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TokenNguoiDung",
                table: "TokenNguoiDung");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NguoiDung",
                table: "NguoiDung");

            migrationBuilder.DropIndex(
                name: "TenNguoiDungIndex",
                table: "NguoiDung");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VaiTroNguoiDung",
                table: "VaiTroNguoiDung");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ThongTinDangNhap",
                table: "ThongTinDangNhap");

            migrationBuilder.DropPrimaryKey(
                name: "PK_QuyenNguoiDung",
                table: "QuyenNguoiDung");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VaiTro",
                table: "VaiTro");

            migrationBuilder.DropIndex(
                name: "TenVaiTroIndex",
                table: "VaiTro");

            migrationBuilder.DropPrimaryKey(
                name: "PK_QuyenVaiTro",
                table: "QuyenVaiTro");

            migrationBuilder.RenameTable(
                name: "TokenNguoiDung",
                newName: "TokenNguoiDung");

            migrationBuilder.RenameTable(
                name: "NguoiDung",
                newName: "NguoiDung");

            migrationBuilder.RenameTable(
                name: "VaiTroNguoiDung",
                newName: "VaiTroNguoiDung");

            migrationBuilder.RenameTable(
                name: "ThongTinDangNhap",
                newName: "ThongTinDangNhap");

            migrationBuilder.RenameTable(
                name: "QuyenNguoiDung",
                newName: "QuyenNguoiDung");

            migrationBuilder.RenameTable(
                name: "VaiTro",
                newName: "VaiTro");

            migrationBuilder.RenameTable(
                name: "QuyenVaiTro",
                newName: "QuyenVaiTro");

            migrationBuilder.RenameColumn(
                name: "NCCDangNhap",
                table: "TokenNguoiDung",
                newName: "NCCDangNhap");

            migrationBuilder.RenameColumn(
                name: "MaNguoiDung",
                table: "TokenNguoiDung",
                newName: "MaNguoiDung");

            migrationBuilder.RenameColumn(
                name: "TenChuanHoa",
                table: "NguoiDung",
                newName: "TenChuanHoa");

            migrationBuilder.RenameColumn(
                name: "EmailChuanHoa",
                table: "NguoiDung",
                newName: "EmailChuanHoa");

            migrationBuilder.RenameColumn(
                name: "MaVaiTro",
                table: "VaiTroNguoiDung",
                newName: "MaVaiTro");

            migrationBuilder.RenameColumn(
                name: "MaNguoiDung",
                table: "VaiTroNguoiDung",
                newName: "MaNguoiDung");

            migrationBuilder.RenameIndex(
                name: "IX_VaiTroNguoiDung_MaVaiTro",
                table: "VaiTroNguoiDung",
                newName: "IX_VaiTroNguoiDung_MaVaiTro");

            migrationBuilder.RenameColumn(
                name: "MaNguoiDung",
                table: "ThongTinDangNhap",
                newName: "MaNguoiDung");

            migrationBuilder.RenameColumn(
                name: "TenNCCDichVu",
                table: "ThongTinDangNhap",
                newName: "TenNCCDichVu");

            migrationBuilder.RenameColumn(
                name: "KhoaNCC",
                table: "ThongTinDangNhap",
                newName: "KhoaNCC");

            migrationBuilder.RenameColumn(
                name: "NCCDangNhap",
                table: "ThongTinDangNhap",
                newName: "NCCDangNhap");

            migrationBuilder.RenameIndex(
                name: "IX_ThongTinDangNhap_MaNguoiDung",
                table: "ThongTinDangNhap",
                newName: "IX_ThongTinDangNhap_MaNguoiDung");

            migrationBuilder.RenameColumn(
                name: "MaNguoiDung",
                table: "QuyenNguoiDung",
                newName: "MaNguoiDung");

            migrationBuilder.RenameColumn(
                name: "GiaTriQuyen",
                table: "QuyenNguoiDung",
                newName: "LoaiQuyen");

            migrationBuilder.RenameColumn(
                name: "LoaiQuyen",
                table: "QuyenNguoiDung",
                newName: "GiaTriQuyen");

            migrationBuilder.RenameIndex(
                name: "IX_QuyenNguoiDung_MaNguoiDung",
                table: "QuyenNguoiDung",
                newName: "IX_QuyenNguoiDung_MaNguoiDung");

            migrationBuilder.RenameColumn(
                name: "TenChuanHoa",
                table: "VaiTro",
                newName: "TenChuanHoa");

            migrationBuilder.RenameColumn(
                name: "MaVaiTro",
                table: "QuyenVaiTro",
                newName: "MaVaiTro");

            migrationBuilder.RenameColumn(
                name: "GiaTriQuyen",
                table: "QuyenVaiTro",
                newName: "LoaiQuyen");

            migrationBuilder.RenameColumn(
                name: "LoaiQuyen",
                table: "QuyenVaiTro",
                newName: "GiaTriQuyen");

            migrationBuilder.RenameIndex(
                name: "IX_QuyenVaiTro_MaVaiTro",
                table: "QuyenVaiTro",
                newName: "IX_QuyenVaiTro_MaVaiTro");

            migrationBuilder.AlterColumn<string>(
                name: "MaTraoDoiTienTe",
                table: "TienTe",
                type: "nvarchar(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MaTienTe",
                table: "TienTe",
                type: "nvarchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "MaThuongHieu",
                table: "ThuongHieu",
                type: "nvarchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "MaThuongHieu",
                table: "SanPham",
                type: "nvarchar(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MaNhomSP",
                table: "SanPham",
                type: "nvarchar(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MaHoSoSP",
                table: "SanPham",
                type: "nvarchar(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MaDonVi",
                table: "SanPham",
                type: "nvarchar(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "MaDanhMuc",
                table: "SanPham",
                type: "nvarchar(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MoTa",
                table: "NhomSP",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "MaNhomSP",
                table: "NhomSP",
                type: "nvarchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "MaNCC",
                table: "NhaCungCap",
                type: "nvarchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "MaHoSoSP",
                table: "HoSoSP",
                type: "nvarchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "MaHoSoSP",
                table: "HoSoSP",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "MaDonVi",
                table: "DonVi",
                type: "nvarchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayTao",
                table: "DonHang",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "MaTienTeDonHang",
                table: "DonHang",
                type: "nvarchar(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "MaTienTeCoSo",
                table: "DonHang",
                type: "nvarchar(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "MaNCC",
                table: "DonHang",
                type: "nvarchar(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "MaDonHang",
                table: "DonHang",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "MaDanhMuc",
                table: "DanhMuc",
                type: "nvarchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "MaDonHang",
                table: "ChiTietDonHang",
                type: "nvarchar(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "MaChiTietDonHang",
                table: "ChiTietDonHang",
                type: "nvarchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_HoSoSP_MaHoSoSP",
                table: "HoSoSP",
                column: "MaHoSoSP");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TokenNguoiDung",
                table: "TokenNguoiDung",
                columns: new[] { "MaNguoiDung", "NCCDangNhap", "TenToken" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_NguoiDung",
                table: "NguoiDung",
                column: "MaNguoiDung");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VaiTroNguoiDung",
                table: "VaiTroNguoiDung",
                columns: new[] { "MaNguoiDung", "MaVaiTro" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ThongTinDangNhap",
                table: "ThongTinDangNhap",
                columns: new[] { "NCCDangNhap", "KhoaNCC" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_QuyenNguoiDung",
                table: "QuyenNguoiDung",
                column: "MaQuyen");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VaiTro",
                table: "VaiTro",
                column: "MaVaiTro");

            migrationBuilder.AddPrimaryKey(
                name: "PK_QuyenVaiTro",
                table: "QuyenVaiTro",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "TenNguoiDungIndex",
                table: "NguoiDung",
                column: "TenChuanHoa",
                unique: true,
                filter: "[TenChuanHoa] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "TenVaiTroIndex",
                table: "VaiTro",
                column: "TenChuanHoa",
                unique: true,
                filter: "[TenChuanHoa] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_QuyenNguoiDung_NguoiDung_MaNguoiDung",
                table: "QuyenNguoiDung",
                column: "MaNguoiDung",
                principalTable: "NguoiDung",
                principalColumn: "MaNguoiDung",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_QuyenVaiTro_VaiTro_MaVaiTro",
                table: "QuyenVaiTro",
                column: "MaVaiTro",
                principalTable: "VaiTro",
                principalColumn: "MaVaiTro",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SanPham_HoSoSP_MaHoSoSP",
                table: "SanPham",
                column: "MaHoSoSP",
                principalTable: "HoSoSP",
                principalColumn: "MaHoSoSP");

            migrationBuilder.AddForeignKey(
                name: "FK_ThongTinDangNhap_NguoiDung_MaNguoiDung",
                table: "ThongTinDangNhap",
                column: "MaNguoiDung",
                principalTable: "NguoiDung",
                principalColumn: "MaNguoiDung",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TokenNguoiDung_NguoiDung_MaNguoiDung",
                table: "TokenNguoiDung",
                column: "MaNguoiDung",
                principalTable: "NguoiDung",
                principalColumn: "MaNguoiDung",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VaiTroNguoiDung_NguoiDung_MaNguoiDung",
                table: "VaiTroNguoiDung",
                column: "MaNguoiDung",
                principalTable: "NguoiDung",
                principalColumn: "MaNguoiDung",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VaiTroNguoiDung_VaiTro_MaVaiTro",
                table: "VaiTroNguoiDung",
                column: "MaVaiTro",
                principalTable: "VaiTro",
                principalColumn: "MaVaiTro",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
