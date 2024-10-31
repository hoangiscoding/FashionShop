using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FashionShop.Migrations
{
    public partial class InitialCreate : Migration
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

            migrationBuilder.DropPrimaryKey(
                name: "PK_VaiTroNguoiDung",
                table: "VaiTroNguoiDung");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VaiTro",
                table: "VaiTro");

            migrationBuilder.DropIndex(
                name: "RoleNameIndex",
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
                name: "UserNameIndex",
                table: "NguoiDung");

            migrationBuilder.RenameTable(
                name: "VaiTroNguoiDung",
                newName: "AspNetUserRoles");

            migrationBuilder.RenameTable(
                name: "VaiTro",
                newName: "AspNetRoles");

            migrationBuilder.RenameTable(
                name: "TokenNguoiDung",
                newName: "AspNetUserTokens");

            migrationBuilder.RenameTable(
                name: "ThongTinDangNhap",
                newName: "AspNetUserLogins");

            migrationBuilder.RenameTable(
                name: "QuyenVaiTro",
                newName: "AspNetRoleClaims");

            migrationBuilder.RenameTable(
                name: "QuyenNguoiDung",
                newName: "AspNetUserClaims");

            migrationBuilder.RenameTable(
                name: "NguoiDung",
                newName: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "MaVaiTro",
                table: "AspNetUserRoles",
                newName: "RoleId");

            migrationBuilder.RenameColumn(
                name: "MaNguoiDung",
                table: "AspNetUserRoles",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_VaiTroNguoiDung_MaVaiTro",
                table: "AspNetUserRoles",
                newName: "IX_AspNetUserRoles_RoleId");

            migrationBuilder.RenameColumn(
                name: "TenChuanHoa",
                table: "AspNetRoles",
                newName: "NormalizedName");

            migrationBuilder.RenameColumn(
                name: "NCCDangNhap",
                table: "AspNetUserTokens",
                newName: "LoginProvider");

            migrationBuilder.RenameColumn(
                name: "MaNguoiDung",
                table: "AspNetUserTokens",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "TenNCCDichVu",
                table: "AspNetUserLogins",
                newName: "ProviderDisplayName");

            migrationBuilder.RenameColumn(
                name: "MaNguoiDung",
                table: "AspNetUserLogins",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "KhoaNCC",
                table: "AspNetUserLogins",
                newName: "ProviderKey");

            migrationBuilder.RenameColumn(
                name: "NCCDangNhap",
                table: "AspNetUserLogins",
                newName: "LoginProvider");

            migrationBuilder.RenameIndex(
                name: "IX_ThongTinDangNhap_MaNguoiDung",
                table: "AspNetUserLogins",
                newName: "IX_AspNetUserLogins_UserId");

            migrationBuilder.RenameColumn(
                name: "MaVaiTro",
                table: "AspNetRoleClaims",
                newName: "RoleId");

            migrationBuilder.RenameColumn(
                name: "LoaiQuyen",
                table: "AspNetRoleClaims",
                newName: "ClaimValue");

            migrationBuilder.RenameColumn(
                name: "GiaTriQuyen",
                table: "AspNetRoleClaims",
                newName: "ClaimType");

            migrationBuilder.RenameIndex(
                name: "IX_QuyenVaiTro_MaVaiTro",
                table: "AspNetRoleClaims",
                newName: "IX_AspNetRoleClaims_RoleId");

            migrationBuilder.RenameColumn(
                name: "MaNguoiDung",
                table: "AspNetUserClaims",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "LoaiQuyen",
                table: "AspNetUserClaims",
                newName: "ClaimValue");

            migrationBuilder.RenameColumn(
                name: "GiaTriQuyen",
                table: "AspNetUserClaims",
                newName: "ClaimType");

            migrationBuilder.RenameIndex(
                name: "IX_QuyenNguoiDung_MaNguoiDung",
                table: "AspNetUserClaims",
                newName: "IX_AspNetUserClaims_UserId");

            migrationBuilder.RenameColumn(
                name: "TenChuanHoa",
                table: "AspNetUsers",
                newName: "NormalizedUserName");

            migrationBuilder.RenameColumn(
                name: "EmailChuanHoa",
                table: "AspNetUsers",
                newName: "NormalizedEmail");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserRoles",
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRoles",
                table: "AspNetRoles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserTokens",
                table: "AspNetUserTokens",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRoleClaims",
                table: "AspNetRoleClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserClaims",
                table: "AspNetUserClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserTokens",
                table: "AspNetUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "UserNameIndex",
                table: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserRoles",
                table: "AspNetUserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserClaims",
                table: "AspNetUserClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetRoles",
                table: "AspNetRoles");

            migrationBuilder.DropIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetRoleClaims",
                table: "AspNetRoleClaims");

            migrationBuilder.RenameTable(
                name: "AspNetUserTokens",
                newName: "TokenNguoiDung");

            migrationBuilder.RenameTable(
                name: "AspNetUsers",
                newName: "NguoiDung");

            migrationBuilder.RenameTable(
                name: "AspNetUserRoles",
                newName: "VaiTroNguoiDung");

            migrationBuilder.RenameTable(
                name: "AspNetUserLogins",
                newName: "ThongTinDangNhap");

            migrationBuilder.RenameTable(
                name: "AspNetUserClaims",
                newName: "QuyenNguoiDung");

            migrationBuilder.RenameTable(
                name: "AspNetRoles",
                newName: "VaiTro");

            migrationBuilder.RenameTable(
                name: "AspNetRoleClaims",
                newName: "QuyenVaiTro");

            migrationBuilder.RenameColumn(
                name: "LoginProvider",
                table: "TokenNguoiDung",
                newName: "NCCDangNhap");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "TokenNguoiDung",
                newName: "MaNguoiDung");

            migrationBuilder.RenameColumn(
                name: "NormalizedUserName",
                table: "NguoiDung",
                newName: "TenChuanHoa");

            migrationBuilder.RenameColumn(
                name: "NormalizedEmail",
                table: "NguoiDung",
                newName: "EmailChuanHoa");

            migrationBuilder.RenameColumn(
                name: "RoleId",
                table: "VaiTroNguoiDung",
                newName: "MaVaiTro");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "VaiTroNguoiDung",
                newName: "MaNguoiDung");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "VaiTroNguoiDung",
                newName: "IX_VaiTroNguoiDung_MaVaiTro");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "ThongTinDangNhap",
                newName: "MaNguoiDung");

            migrationBuilder.RenameColumn(
                name: "ProviderDisplayName",
                table: "ThongTinDangNhap",
                newName: "TenNCCDichVu");

            migrationBuilder.RenameColumn(
                name: "ProviderKey",
                table: "ThongTinDangNhap",
                newName: "KhoaNCC");

            migrationBuilder.RenameColumn(
                name: "LoginProvider",
                table: "ThongTinDangNhap",
                newName: "NCCDangNhap");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "ThongTinDangNhap",
                newName: "IX_ThongTinDangNhap_MaNguoiDung");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "QuyenNguoiDung",
                newName: "MaNguoiDung");

            migrationBuilder.RenameColumn(
                name: "ClaimValue",
                table: "QuyenNguoiDung",
                newName: "LoaiQuyen");

            migrationBuilder.RenameColumn(
                name: "ClaimType",
                table: "QuyenNguoiDung",
                newName: "GiaTriQuyen");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "QuyenNguoiDung",
                newName: "IX_QuyenNguoiDung_MaNguoiDung");

            migrationBuilder.RenameColumn(
                name: "NormalizedName",
                table: "VaiTro",
                newName: "TenChuanHoa");

            migrationBuilder.RenameColumn(
                name: "RoleId",
                table: "QuyenVaiTro",
                newName: "MaVaiTro");

            migrationBuilder.RenameColumn(
                name: "ClaimValue",
                table: "QuyenVaiTro",
                newName: "LoaiQuyen");

            migrationBuilder.RenameColumn(
                name: "ClaimType",
                table: "QuyenVaiTro",
                newName: "GiaTriQuyen");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "QuyenVaiTro",
                newName: "IX_QuyenVaiTro_MaVaiTro");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TokenNguoiDung",
                table: "TokenNguoiDung",
                columns: new[] { "MaNguoiDung", "NCCDangNhap", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_NguoiDung",
                table: "NguoiDung",
                column: "Id");

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
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VaiTro",
                table: "VaiTro",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_QuyenVaiTro",
                table: "QuyenVaiTro",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "NguoiDung",
                column: "TenChuanHoa",
                unique: true,
                filter: "[TenChuanHoa] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "VaiTro",
                column: "TenChuanHoa",
                unique: true,
                filter: "[TenChuanHoa] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_QuyenNguoiDung_NguoiDung_MaNguoiDung",
                table: "QuyenNguoiDung",
                column: "MaNguoiDung",
                principalTable: "NguoiDung",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_QuyenVaiTro_VaiTro_MaVaiTro",
                table: "QuyenVaiTro",
                column: "MaVaiTro",
                principalTable: "VaiTro",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ThongTinDangNhap_NguoiDung_MaNguoiDung",
                table: "ThongTinDangNhap",
                column: "MaNguoiDung",
                principalTable: "NguoiDung",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TokenNguoiDung_NguoiDung_MaNguoiDung",
                table: "TokenNguoiDung",
                column: "MaNguoiDung",
                principalTable: "NguoiDung",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VaiTroNguoiDung_NguoiDung_MaNguoiDung",
                table: "VaiTroNguoiDung",
                column: "MaNguoiDung",
                principalTable: "NguoiDung",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VaiTroNguoiDung_VaiTro_MaVaiTro",
                table: "VaiTroNguoiDung",
                column: "MaVaiTro",
                principalTable: "VaiTro",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
