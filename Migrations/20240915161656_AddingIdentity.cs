using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FashionShop.Migrations
{
    public partial class AddingIdentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VaiTro",
                columns: table => new
                {
                    MaVaiTro = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TenVaiTro = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    TenChuanHoa = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    DauThoiGian = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VaiTro", x => x.MaVaiTro);
                });

            migrationBuilder.CreateTable(
                name: "NguoiDung",
                columns: table => new
                {
                    MaNguoiDung = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    TenDangNhap = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    TenChuanHoa = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailChuanHoa = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    XacThucEmail = table.Column<bool>(type: "bit", nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConDauBaoMat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DauHieuDongThoi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoDienThoai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XacThucSDT = table.Column<bool>(type: "bit", nullable: false),
                    XacThuc2Buoc = table.Column<bool>(type: "bit", nullable: false),
                    ThoiDiemKhoaTK = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false),
                    SoLanDangNhapThatBai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NguoiDung", x => x.MaNguoiDung);
                });

            migrationBuilder.CreateTable(
                name: "QuyenVaiTro",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaVaiTro = table.Column<string>(type: "nvarchar(40)", nullable: false),
                    LoaiQuyen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GiaTriQuyen = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuyenVaiTro", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuyenVaiTro_VaiTro_MaVaiTro",
                        column: x => x.MaVaiTro,
                        principalTable: "VaiTro",
                        principalColumn: "MaVaiTro",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QuyenNguoiDung",
                columns: table => new
                {
                    MaQuyen = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaNguoiDung = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    LoaiQuyen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GiaTri = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuyenNguoiDung", x => x.MaQuyen);
                    table.ForeignKey(
                        name: "FK_QuyenNguoiDung_NguoiDung_MaNguoiDung",
                        column: x => x.MaNguoiDung,
                        principalTable: "NguoiDung",
                        principalColumn: "NguoiDung",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ThongTinDangNhap",
                columns: table => new
                {
                    NCCDangNhap = table.Column<string>(type: "nvarchar50)", maxLength: 50, nullable: false),
                    KhoaNCC = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    TenNCCDichVu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaNguoiDung = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThongTinDangNhap", x => new { x.NCCDangNhap, x.KhoaNCC });
                    table.ForeignKey(
                        name: "FK_ThongTinDangNhap_NguoiDung_MaNguoiDung",
                        column: x => x.MaNguoiDung,
                        principalTable: "NguoiDung",
                        principalColumn: "MaNguoiDung",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VaiTroNguoiDung",
                columns: table => new
                {
                    MaNguoiDung = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    MaVaiTro = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VaiTroNguoiDung", x => new { x.MaNguoiDung, x.MaVaiTro });
                    table.ForeignKey(
                        name: "FK_VaiTroNguoiDung_VaiTro_MaVaiTro",
                        column: x => x.MaVaiTro,
                        principalTable: "VaiTro",
                        principalColumn: "MaVaiTro",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VaiTroNguoiDung_NguoiDung_MaNguoiDung",
                        column: x => x.MaNguoiDung,
                        principalTable: "NguoiDung",
                        principalColumn: "MaNguoiDung",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TokenNguoiDung",
                columns: table => new
                {
                    MaNguoiDung = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    NCCDangNhap = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    TenToken = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    GiaTri = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TokenNguoiDung", x => new { x.MaNguoiDung, x.NCCDangNhap, x.TenToken });
                    table.ForeignKey(
                        name: "FK_TokenNguoiDung_NguoiDung_MaNguoiDung",
                        column: x => x.MaNguoiDung,
                        principalTable: "NguoiDung",
                        principalColumn: "MaNguoiDung",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_QuyenVaiTro_MaVaiTro",
                table: "QuyenVaiTro",
                column: "MaVaiTro");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "VaiTro",
                column: "TenChuanHoa",
                unique: true,
                filter: "[TenChuanHoa] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_QuyenNguoiDung_MaNguoiDung",
                table: "QuyenNguoiDung",
                column: "MaNguoiDung");

            migrationBuilder.CreateIndex(
                name: "IX_ThongTinDangNhap_MaNguoiDung",
                table: "ThongTinDangNhap",
                column: "MaNguoiDung");

            migrationBuilder.CreateIndex(
                name: "IX_VaiTroNguoiDung_MaVaiTro",
                table: "VaiTroNguoiDung",
                column: "MaVaiTro");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "NguoiDung",
                column: "EmailChuanHoa");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "NguoiDung",
                column: "TenChuanHoa",
                unique: true,
                filter: "[TenChuanHoa] IS NOT NULL");
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
                name: "VaiTro");

            migrationBuilder.DropTable(
                name: "NguoiDung");
        }
    }
}
//