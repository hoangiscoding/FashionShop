using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FashionShop.Data
{
    public class InventoryContext : IdentityDbContext<IdentityUser>
    {
        public InventoryContext(DbContextOptions<InventoryContext> options) : base(options)
        {
        }

        public virtual DbSet<Unit> DonVi { get; set; }
        public virtual DbSet<Brand> ThuongHieu { get; set; }
        public virtual DbSet<Category> DanhMuc { get; set; }
        public virtual DbSet<ProductGroup> NhomSP { get; set; }
        public virtual DbSet<ProductProfile> HoSoSP { get; set; }
        public virtual DbSet<Product> SanPham { get; set; }
        public virtual DbSet<Supplier> NhaCungCap { get; set; }
        public virtual DbSet<Currency> TienTe { get; set; }
        public virtual DbSet<DonHang> DonHang { get; set; }
        public virtual DbSet<PoDetail> ChiTietDonHang { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityUser>(entity =>
            {
                entity.ToTable("NguoiDung");
                entity.Property(e => e.Id).HasColumnName("MaNguoiDung");
                entity.Property(e => e.UserName).HasColumnName("TenDangNhap");
                entity.Property(e => e.NormalizedUserName).HasColumnName("TenChuanHoa");
                entity.Property(e => e.Email).HasColumnName("Email");
                entity.Property(e => e.NormalizedEmail).HasColumnName("EmailChuanHoa");
                entity.Property(e => e.EmailConfirmed).HasColumnName("XacThucEmail");
                entity.Property(e => e.PasswordHash).HasColumnName("MatKhau");
                entity.Property(e => e.SecurityStamp).HasColumnName("ConDauBaoMat");
                entity.Property(e => e.ConcurrencyStamp).HasColumnName("DauHieuDongThoi");
                entity.Property(e => e.PhoneNumber).HasColumnName("SoDienThoai");
                entity.Property(e => e.PhoneNumberConfirmed).HasColumnName("XacThucSDT");
                entity.Property(e => e.TwoFactorEnabled).HasColumnName("XacThuc2Buoc");
                entity.Property(e => e.LockoutEnd).HasColumnName("ThoiDiemKhoaTK");
                entity.Property(e => e.LockoutEnabled).HasColumnName("TrangThai");
                entity.Property(e => e.AccessFailedCount).HasColumnName("SoLanDangNhapThatBai");
            });

            modelBuilder.Entity<IdentityRole>(entity =>
            {
                entity.ToTable("VaiTro");
                entity.Property(e => e.Id).HasColumnName("MaVaiTro");
                entity.Property(e => e.Name).HasColumnName("TenVaiTro");
                entity.Property(e => e.NormalizedName).HasColumnName("TenChuanHoa");
                entity.Property(e => e.ConcurrencyStamp).HasColumnName("DauThoiGian");
            });

            modelBuilder.Entity<IdentityUserRole<string>>(entity =>
            {
                entity.ToTable("VaiTroNguoiDung");
                entity.Property(e => e.UserId).HasColumnName("MaNguoiDung");
                entity.Property(e => e.RoleId).HasColumnName("MaVaiTro");
            });

            modelBuilder.Entity<IdentityUserClaim<string>>(entity =>
            {
                entity.ToTable("QuyenNguoiDung");
                entity.Property(e => e.Id).HasColumnName("MaQuyen");
                entity.Property(e => e.UserId).HasColumnName("MaNguoiDung");
                entity.Property(e => e.ClaimType).HasColumnName("LoaiQuyen");
                entity.Property(e => e.ClaimValue).HasColumnName("GiaTriQuyen");
            });

            modelBuilder.Entity<IdentityUserLogin<string>>(entity =>
            {
                entity.ToTable("ThongTinDangNhap");
                entity.Property(e => e.LoginProvider).HasColumnName("NCCDangNhap");
                entity.Property(e => e.ProviderKey).HasColumnName("KhoaNCC");
                entity.Property(e => e.ProviderDisplayName).HasColumnName("TenNCCDichVu");
                entity.Property(e => e.UserId).HasColumnName("MaNguoiDung");
            });

            modelBuilder.Entity<IdentityUserToken<string>>(entity =>
            {
                entity.ToTable("TokenNguoiDung");
                entity.Property(e => e.UserId).HasColumnName("MaNguoiDung");
                entity.Property(e => e.LoginProvider).HasColumnName("NCCDangNhap");
                entity.Property(e => e.Name).HasColumnName("TenToken");
                entity.Property(e => e.Value).HasColumnName("GiaTri");
            });

            modelBuilder.Entity<IdentityRoleClaim<string>>(entity =>
            {
                entity.ToTable("QuyenVaiTro");
                entity.Property(e => e.Id).HasColumnName("Id");
                entity.Property(e => e.RoleId).HasColumnName("MaVaiTro");
                entity.Property(e => e.ClaimType).HasColumnName("LoaiQuyen");
                entity.Property(e => e.ClaimValue).HasColumnName("GiaTriQuyen");
            });

            // Đổi tên các bảng mặc định của Identity
            modelBuilder.Entity<IdentityUser>(entity => entity.ToTable("NguoiDung"));
            modelBuilder.Entity<IdentityRole>(entity => entity.ToTable("VaiTro"));
            modelBuilder.Entity<IdentityUserRole<string>>(entity => entity.ToTable("VaiTroNguoiDung"));
            modelBuilder.Entity<IdentityUserClaim<string>>(entity => entity.ToTable("QuyenNguoiDung"));
            modelBuilder.Entity<IdentityUserLogin<string>>(entity => entity.ToTable("ThongTinDangNhap"));
            modelBuilder.Entity<IdentityUserToken<string>>(entity => entity.ToTable("TokenNguoiDung"));
            modelBuilder.Entity<IdentityRoleClaim<string>>(entity => entity.ToTable("QuyenVaiTro"));

        }
    }
}
