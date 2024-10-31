--CREATE DATABASE FashionShopTest
USE [FashionShopTest]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 10/26/2024 9:58:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LichSuPhienBan](
	[MaPhienBan] [nvarchar](150) NOT NULL,
	[PhienBanSP] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK_LichSuPhienBan] PRIMARY KEY CLUSTERED 
(
	[MaPhienBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 10/26/2024 9:58:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuyenVaiTro](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MaVaiTro] [nvarchar](50) NOT NULL,
	[LoaiQuyen] [nvarchar](max) NULL,
	[GiaTriQuyen] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 10/26/2024 9:58:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VaiTro](
	[MaVaiTro] [nvarchar](50) NOT NULL,
	[TenVaiTro] [nvarchar](256) NULL,
	[TenChuanHoa] [nvarchar](256) NULL,
	[DauThoiGian] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[MaVaiTro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 10/26/2024 9:58:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuyenNguoiDung](
	[MaQuyen] [int] IDENTITY(1,1) NOT NULL,
	[MaNguoiDung] [nvarchar](50) NOT NULL,
	[LoaiQuyen] [nvarchar](max) NULL,
	[GiaTri] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[MaQuyen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 10/26/2024 9:58:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThongTinDangNhap](
	[NCCDangNhap] [nvarchar](50) NOT NULL,
	[KhoaNCC] [nvarchar](128) NOT NULL,
	[TenNCCDichVu] [nvarchar](max) NULL,
	[MaNguoiDung] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[NCCDangNhap] ASC,
	[KhoaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 10/26/2024 9:58:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VaiTroNguoiDung](
	[MaNguoiDung] [nvarchar](50) NOT NULL,
	[MaVaiTro] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[MaNguoiDung] ASC,
	[MaVaiTro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 10/26/2024 9:58:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguoiDung](
	[MaNguoiDung] [nvarchar](50) NOT NULL,
	[TenDangNhap] [nvarchar](250) NOT NULL,
	[TenChuanHoa] [nvarchar](250) NULL,
	[Email] [nvarchar](256) NULL,
	[EmailChuanHoa] [nvarchar](256) NULL,
	[XacThucEmail] [bit] NOT NULL,
	[MatKhau] [nvarchar](max) NULL,
	[ConDauBaoMat] [nvarchar](max) NULL,
	[DauHieuDongThoi] [nvarchar](max) NULL,
	[SoDienThoai] [nvarchar](max) NULL,
	[XacThucSDT] [bit] NOT NULL,
	[XacThuc2Buoc] [bit] NOT NULL,
	[ThoiDiemKhoaTK] [datetimeoffset](7) NULL,
	[TrangThai] [bit] NOT NULL,
	[SoLanDangNhapThatBai] [int] NOT NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[MaNguoiDung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 10/26/2024 9:58:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TokenNguoiDung](
	[MaNguoiDung] [nvarchar](50) NOT NULL,
	[NCCDangNhap] [nvarchar](128) NOT NULL,
	[TenToken] [nvarchar](128) NOT NULL,
	[GiaTri] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[MaNguoiDung] ASC,
	[NCCDangNhap] ASC,
	[TenToken] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Brands]    Script Date: 10/26/2024 9:58:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThuongHieu](
	[MaThuongHieu] [nvarchar](50) NOT NULL,
	[TenThuongHieu] [nvarchar](50) NOT NULL,
	[MoTa] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_ThuongHieu] PRIMARY KEY CLUSTERED 
(
	[MaThuongHieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 10/26/2024 9:58:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanhMuc](
	[MaDanhMuc] [nvarchar](50) NOT NULL,
	[TenDanhMuc] [nvarchar](50) NOT NULL,
	[MoTa] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_DanhMuc] PRIMARY KEY CLUSTERED 
(
	[MaDanhMuc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Currencies]    Script Date: 10/26/2024 9:58:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TienTe](
	[MaTienTe] [nvarchar](50) NOT NULL,
	[TenTienTe] [nvarchar](50) NOT NULL,
	[MoTa] [nvarchar](100) NOT NULL,
	[TyGiaHoiDoai] [money] NOT NULL,
	[MaTraoDoiTienTe] [nvarchar](50) NULL,
 CONSTRAINT [PK_TienTe] PRIMARY KEY CLUSTERED 
(
	[MaTienTe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PoDetails]    Script Date: 10/26/2024 9:58:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietDonHang](
	[MaChiTietDonHang] [nvarchar](50) NOT NULL,
	[MaDonHang] [nvarchar](50) NOT NULL,
	[MaSP] [nvarchar](50) NOT NULL,
	[SoLuong] [money] NOT NULL,
	[Fob] [smallmoney] NOT NULL,
	[PrcInBaseCur] [smallmoney] NOT NULL,
 CONSTRAINT [PK_PoDetails] PRIMARY KEY CLUSTERED 
(
	[MaChiTietDonHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PoHeaders]    Script Date: 10/26/2024 9:58:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonHang](
	[MaDonHang] [nvarchar](50) NOT NULL,
	[NgayTao] [datetime] NOT NULL,
	[MaNCC] [nvarchar](50) NOT NULL,
	[MaTienTeCoSo] [nvarchar](50) NOT NULL,
	[MaTienTeDonHang] [nvarchar](50) NOT NULL,
	[TyGiaHoiDoai] [smallmoney] NOT NULL,
	[GiamGia] [int] NOT NULL,
	[MaBaoGia] [nvarchar](50) NOT NULL,
	[NgayBaoGia] [datetime2](7) NOT NULL,
	[DieuKhoanThanhToan] [nvarchar](500) NOT NULL,
	[GhiChu] [nvarchar](500) NOT NULL,
 CONSTRAINT [PK_PoHeaders] PRIMARY KEY CLUSTERED 
(
	[MaDonHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductGroups]    Script Date: 10/26/2024 9:58:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhomSP](
	[MaNhomSP] [nvarchar](50) NOT NULL,
	[TenNhom] [nvarchar](50) NOT NULL,
	[MoTa] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_ProductGroups] PRIMARY KEY CLUSTERED 
(
	[MaNhomSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductProfiles]    Script Date: 10/26/2024 9:58:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoSoSP](
	[MaHoSoSP] [nvarchar](50) NOT NULL,
	[TenHoSoSP] [nvarchar](25) NOT NULL,
	[MoTa] [nvarchar](75) NOT NULL,
 CONSTRAINT [PK_HoSoSP] PRIMARY KEY CLUSTERED 
(
	[MaHoSoSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 10/26/2024 9:58:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaSP] [nvarchar](50) NOT NULL,
	[TenSP] [nvarchar](75) NOT NULL,
	[MoTa] [nvarchar](255) NOT NULL,
	[DonGiaNhap] [money] NOT NULL,
	[DonGiaBan] [money] NOT NULL,
	[MaDonVi] [nvarchar](50) NOT NULL,
	[MaThuongHieu] [nvarchar](50) NULL,
	[MaDanhMuc] [nvarchar](50) NULL,
	[MaNhomSP] [nvarchar](50) NULL,
	[MaHoSoSP] [nvarchar](50) NULL,
	[Anh] [nvarchar](max) NULL,
 CONSTRAINT [PK_SanPham] PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Suppliers]    Script Date: 10/26/2024 9:58:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[MaNCC] [nvarchar](50) NOT NULL,
	[TenNCC] [nvarchar](75) NOT NULL,
	[Email] [nvarchar](75) NOT NULL,
	[DiaChi] [nvarchar](75) NULL,
	[SDT] [nvarchar](75) NULL,
 CONSTRAINT [PK_NhaCungCap] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Units]    Script Date: 10/26/2024 9:58:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

use FashionShopTest
CREATE TABLE [dbo].[DonVi](
	[MaDonVi] [nvarchar](50) NOT NULL,
	[TenDonVi] [nvarchar](25) NOT NULL,
	[MoTa] [nvarchar](75) NOT NULL,
 CONSTRAINT [PK_DonVi] PRIMARY KEY CLUSTERED 
(
	[MaDonVi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

-----------------------------------
/*
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240910122423_InitialDB', N'5.0.7')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240912123058_InitDatabase', N'5.0.9')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240915161656_AddingIdentity', N'5.0.9')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240918163718_AddingSupportingTables', N'5.0.9')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240923104938_addingProductMaster', N'5.0.9')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240926171013_AddedBrandidToProduct', N'5.0.9')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240928171809_AddedCategoryidToProduct', N'5.0.9')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20241001173108_AddingOtherProperties', N'5.0.9')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20241005084236_AddedProductPhoto', N'5.0.9')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20241010083237_AddSupplierTable', N'5.0.9')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20241013102532_AddCurrencies', N'6.0.4')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20241018103724_AddSelfForeignKey', N'6.0.4')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20241022124501_CreatingPoHeader', N'6.0.4')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20241025141441_CreatePoDetails', N'6.0.4')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20241026174454_AddingPodetailsList', N'6.0.4')
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'13cd0ecf-570e-4866-a964-c064201e3746', N'tester', N'TESTER', N'test@test.com', N'TEST@TEST.COM', 0, N'AQAAAAEAACcQAAAAEECpuKX1rcduM+6Ncc45pdVdferxkmTgXxNe6IXkgrqGdPc3dtLf/Ry6gnoWHLIsyQ==', N'MSGYBABHSBKFTNYEFNIQXP5HCWZP57WI', N'0740fede-e2eb-44e2-af16-b8a6c3254b4c', NULL, 0, 0, NULL, 1, 0)
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'c7ae4971-55f1-4cc6-bde7-42b8d1758ff4', N'anizmohammed', N'ANIZMOHAMMED', N'aniz1@yahoo.com', N'ANIZ1@YAHOO.COM', 0, N'AQAAAAEAACcQAAAAEK1oU4YlhREQOs66kr50jBDpDp9DDDse0/VMj3YUuJmhAgnA31IzRUO7+Gx7T0u35w==', N'TEHUY4LMCX7IXTVLAMESGCLKTSSQZ2MD', N'5e1b5eb6-d530-42e6-95ed-b0f9feb965bc', NULL, 0, 0, NULL, 1, 0)
GO
SET IDENTITY_INSERT [dbo].[Brands] ON 
GO
INSERT [dbo].[Brands] ([Id], [Name], [Description]) VALUES (1, N'Fanta', N'Fanta')
GO
INSERT [dbo].[Brands] ([Id], [Name], [Description]) VALUES (2, N'Dettol', N'Dettol')
GO
INSERT [dbo].[Brands] ([Id], [Name], [Description]) VALUES (3, N'Nike', N'Nike')
GO
INSERT [dbo].[Brands] ([Id], [Name], [Description]) VALUES (4, N'Peter England', N'Peter England')
GO
INSERT [dbo].[Brands] ([Id], [Name], [Description]) VALUES (5, N'Aavin', N'Aavin')
GO
INSERT [dbo].[Brands] ([Id], [Name], [Description]) VALUES (6, N'Nestle', N'Nestle')
GO
INSERT [dbo].[Brands] ([Id], [Name], [Description]) VALUES (7, N'Amul', N'Amul')
GO
INSERT [dbo].[Brands] ([Id], [Name], [Description]) VALUES (8, N'Smac', N'Smac')
GO
INSERT [dbo].[Brands] ([Id], [Name], [Description]) VALUES (9, N'Mr.Muscle', N'Mr.Muscle')
GO
SET IDENTITY_INSERT [dbo].[Brands] OFF
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 
GO
INSERT [dbo].[Categories] ([Id], [Name], [Description]) VALUES (6, N'Shirts', N'Shirts')
GO
INSERT [dbo].[Categories] ([Id], [Name], [Description]) VALUES (7, N'Polos', N'Polos')
GO
INSERT [dbo].[Categories] ([Id], [Name], [Description]) VALUES (8, N'Jackets', N'Jackets')
GO
INSERT [dbo].[Categories] ([Id], [Name], [Description]) VALUES (9, N'Hoodies', N'Hoodies')
GO
INSERT [dbo].[Categories] ([Id], [Name], [Description]) VALUES (10, N'Pullover', N'Pullover')
GO
INSERT [dbo].[Categories] ([Id], [Name], [Description]) VALUES (11, N'Skirts', N'Skirts')
GO
INSERT [dbo].[Categories] ([Id], [Name], [Description]) VALUES (12, N'Android', N'Android')
GO
INSERT [dbo].[Categories] ([Id], [Name], [Description]) VALUES (13, N'Mac', N'Mac Devices')
GO
INSERT [dbo].[Categories] ([Id], [Name], [Description]) VALUES (14, N'CoolDrinks', N'CoolDrinks')
GO
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
SET IDENTITY_INSERT [dbo].[Currencies] ON 
GO
INSERT [dbo].[Currencies] ([Id], [Name], [Description], [ExchangeRate], [ExchangeCurrencyId]) VALUES (1, N'AED', N'United Arab Emirates Dirham', 1.0000, 1)
GO
INSERT [dbo].[Currencies] ([Id], [Name], [Description], [ExchangeRate], [ExchangeCurrencyId]) VALUES (3, N'INR', N'Indian Rupees', 0.0470, 1)
GO
INSERT [dbo].[Currencies] ([Id], [Name], [Description], [ExchangeRate], [ExchangeCurrencyId]) VALUES (6, N'USD', N'USDollar', 3.6600, 1)
GO
SET IDENTITY_INSERT [dbo].[Currencies] OFF
GO
SET IDENTITY_INSERT [dbo].[PoDetails] ON 
GO
INSERT [dbo].[PoDetails] ([Id], [PoId], [ProductCode], [Quantity], [Fob], [PrcInBaseCur]) VALUES (1, 2, N'GR0002', 25.0000, 15.0000, 15.0000)
GO
INSERT [dbo].[PoDetails] ([Id], [PoId], [ProductCode], [Quantity], [Fob], [PrcInBaseCur]) VALUES (2, 2, N'CD0001', 50.0000, 2.0000, 2.0000)
GO
INSERT [dbo].[PoDetails] ([Id], [PoId], [ProductCode], [Quantity], [Fob], [PrcInBaseCur]) VALUES (3, 3, N'GR0003', 50.0000, 25.0000, 25.0000)
GO
INSERT [dbo].[PoDetails] ([Id], [PoId], [ProductCode], [Quantity], [Fob], [PrcInBaseCur]) VALUES (4, 3, N'GR0002', 25.0000, 20.0000, 20.0000)
GO
INSERT [dbo].[PoDetails] ([Id], [PoId], [ProductCode], [Quantity], [Fob], [PrcInBaseCur]) VALUES (19, 4, N'GR0002', 5.0000, 15.0000, 0.7050)
GO
INSERT [dbo].[PoDetails] ([Id], [PoId], [ProductCode], [Quantity], [Fob], [PrcInBaseCur]) VALUES (20, 4, N'GR0003', 4.0000, 15.0000, 0.7050)
GO
INSERT [dbo].[PoDetails] ([Id], [PoId], [ProductCode], [Quantity], [Fob], [PrcInBaseCur]) VALUES (21, 5, N'CD0001', 10.0000, 15.0000, 0.7050)
GO
INSERT [dbo].[PoDetails] ([Id], [PoId], [ProductCode], [Quantity], [Fob], [PrcInBaseCur]) VALUES (22, 5, N'GR0001', 20.0000, 25.0000, 1.1750)
GO
INSERT [dbo].[PoDetails] ([Id], [PoId], [ProductCode], [Quantity], [Fob], [PrcInBaseCur]) VALUES (23, 5, N'CD0001', 12.0000, 13.0000, 0.6110)
GO
INSERT [dbo].[PoDetails] ([Id], [PoId], [ProductCode], [Quantity], [Fob], [PrcInBaseCur]) VALUES (28, 6, N'GR0002', 50.0000, 5.0000, 0.2350)
GO
INSERT [dbo].[PoDetails] ([Id], [PoId], [ProductCode], [Quantity], [Fob], [PrcInBaseCur]) VALUES (29, 6, N'CD0001', 25.0000, 25.0000, 1.1750)
GO
INSERT [dbo].[PoDetails] ([Id], [PoId], [ProductCode], [Quantity], [Fob], [PrcInBaseCur]) VALUES (42, 10, N'GR0003', 15.0000, 600.0000, 28.2000)
GO
INSERT [dbo].[PoDetails] ([Id], [PoId], [ProductCode], [Quantity], [Fob], [PrcInBaseCur]) VALUES (43, 10, N'CI0001', 25.0000, 50.0000, 2.3500)
GO
INSERT [dbo].[PoDetails] ([Id], [PoId], [ProductCode], [Quantity], [Fob], [PrcInBaseCur]) VALUES (44, 11, N'GR0003', 15.0000, 500.0000, 23.5000)
GO
INSERT [dbo].[PoDetails] ([Id], [PoId], [ProductCode], [Quantity], [Fob], [PrcInBaseCur]) VALUES (45, 11, N'GR0002', 25.0000, 400.0000, 18.8000)
GO
INSERT [dbo].[PoDetails] ([Id], [PoId], [ProductCode], [Quantity], [Fob], [PrcInBaseCur]) VALUES (46, 11, N'CI0001', 50.0000, 50.0000, 2.3500)
GO
INSERT [dbo].[PoDetails] ([Id], [PoId], [ProductCode], [Quantity], [Fob], [PrcInBaseCur]) VALUES (47, 11, N'GR0002', 45.0000, 525.0000, 24.6750)
GO
INSERT [dbo].[PoDetails] ([Id], [PoId], [ProductCode], [Quantity], [Fob], [PrcInBaseCur]) VALUES (48, 11, N'GR0001', 75.0000, 750.0000, 35.2500)
GO
INSERT [dbo].[PoDetails] ([Id], [PoId], [ProductCode], [Quantity], [Fob], [PrcInBaseCur]) VALUES (49, 12, N'CI0001', 15.0000, 50.0000, 2.3500)
GO
INSERT [dbo].[PoDetails] ([Id], [PoId], [ProductCode], [Quantity], [Fob], [PrcInBaseCur]) VALUES (50, 12, N'GR0003', 25.0000, 500.0000, 23.5000)
GO
INSERT [dbo].[PoDetails] ([Id], [PoId], [ProductCode], [Quantity], [Fob], [PrcInBaseCur]) VALUES (51, 13, N'GR0003', 30.0000, 550.0000, 25.8500)
GO
INSERT [dbo].[PoDetails] ([Id], [PoId], [ProductCode], [Quantity], [Fob], [PrcInBaseCur]) VALUES (52, 13, N'CI0001', 45.0000, 50.0000, 2.3500)
GO
INSERT [dbo].[PoDetails] ([Id], [PoId], [ProductCode], [Quantity], [Fob], [PrcInBaseCur]) VALUES (53, 13, N'CD0001', 500.0000, 25.0000, 1.1750)
GO
SET IDENTITY_INSERT [dbo].[PoDetails] OFF
GO
SET IDENTITY_INSERT [dbo].[PoHeaders] ON 
GO
INSERT [dbo].[PoHeaders] ([Id], [PoNumber], [PoDate], [SupplierId], [BaseCurrencyId], [PoCurrencyId], [ExchangeRate], [DiscountPercent], [QuotationNo], [QuotationDate], [PaymentTerms], [Remarks]) VALUES (2, N'PO00001', CAST(N'2022-05-22T00:00:00.0000000' AS DateTime2), 4, 1, 1, 1.0000, 0.0000, N'Quot0001', CAST(N'2022-05-10T00:00:00.0000000' AS DateTime2), N' ', N' ')
GO
INSERT [dbo].[PoHeaders] ([Id], [PoNumber], [PoDate], [SupplierId], [BaseCurrencyId], [PoCurrencyId], [ExchangeRate], [DiscountPercent], [QuotationNo], [QuotationDate], [PaymentTerms], [Remarks]) VALUES (3, N'PO00002', CAST(N'2022-05-21T00:00:00.0000000' AS DateTime2), 6, 1, 1, 1.0000, 0.0000, N'Quot0002', CAST(N'2022-08-22T00:00:00.0000000' AS DateTime2), N' ', N' ')
GO
INSERT [dbo].[PoHeaders] ([Id], [PoNumber], [PoDate], [SupplierId], [BaseCurrencyId], [PoCurrencyId], [ExchangeRate], [DiscountPercent], [QuotationNo], [QuotationDate], [PaymentTerms], [Remarks]) VALUES (4, N'PO00003', CAST(N'2022-05-20T00:00:00.0000000' AS DateTime2), 3, 1, 3, 0.0470, 0.0000, N'Quot0003', CAST(N'2022-05-22T00:00:00.0000000' AS DateTime2), N' ', N' ')
GO
INSERT [dbo].[PoHeaders] ([Id], [PoNumber], [PoDate], [SupplierId], [BaseCurrencyId], [PoCurrencyId], [ExchangeRate], [DiscountPercent], [QuotationNo], [QuotationDate], [PaymentTerms], [Remarks]) VALUES (5, N'PO00004', CAST(N'2022-05-22T00:00:00.0000000' AS DateTime2), 6, 1, 3, 0.0470, 0.0000, N'Quot0004', CAST(N'2022-05-09T00:00:00.0000000' AS DateTime2), N' ', N' ')
GO
INSERT [dbo].[PoHeaders] ([Id], [PoNumber], [PoDate], [SupplierId], [BaseCurrencyId], [PoCurrencyId], [ExchangeRate], [DiscountPercent], [QuotationNo], [QuotationDate], [PaymentTerms], [Remarks]) VALUES (6, N'PO00005', CAST(N'2022-05-22T00:00:00.0000000' AS DateTime2), 5, 1, 3, 0.0470, 0.0000, N'Quot0005', CAST(N'2022-05-16T00:00:00.0000000' AS DateTime2), N' ', N' ')
GO
INSERT [dbo].[PoHeaders] ([Id], [PoNumber], [PoDate], [SupplierId], [BaseCurrencyId], [PoCurrencyId], [ExchangeRate], [DiscountPercent], [QuotationNo], [QuotationDate], [PaymentTerms], [Remarks]) VALUES (10, N'PO00006', CAST(N'2022-07-25T00:00:00.0000000' AS DateTime2), 6, 1, 3, 0.0470, 0.0000, N'QUOT00010', CAST(N'2022-07-25T00:00:00.0000000' AS DateTime2), N' ', N' ')
GO
INSERT [dbo].[PoHeaders] ([Id], [PoNumber], [PoDate], [SupplierId], [BaseCurrencyId], [PoCurrencyId], [ExchangeRate], [DiscountPercent], [QuotationNo], [QuotationDate], [PaymentTerms], [Remarks]) VALUES (11, N'PO00007', CAST(N'2022-07-25T00:00:00.0000000' AS DateTime2), 5, 1, 3, 0.0470, 0.0000, N'QUOT00011', CAST(N'2022-07-25T00:00:00.0000000' AS DateTime2), N' ', N' ')
GO
INSERT [dbo].[PoHeaders] ([Id], [PoNumber], [PoDate], [SupplierId], [BaseCurrencyId], [PoCurrencyId], [ExchangeRate], [DiscountPercent], [QuotationNo], [QuotationDate], [PaymentTerms], [Remarks]) VALUES (12, N'PO00008', CAST(N'2022-07-25T00:00:00.0000000' AS DateTime2), 6, 1, 3, 0.0470, 0.0000, N'QUOT00012', CAST(N'2022-07-25T00:00:00.0000000' AS DateTime2), N' ', N' ')
GO
INSERT [dbo].[PoHeaders] ([Id], [PoNumber], [PoDate], [SupplierId], [BaseCurrencyId], [PoCurrencyId], [ExchangeRate], [DiscountPercent], [QuotationNo], [QuotationDate], [PaymentTerms], [Remarks]) VALUES (13, N'PO00009', CAST(N'2022-07-25T00:00:00.0000000' AS DateTime2), 6, 1, 3, 0.0470, 0.0000, N'QUOT00013', CAST(N'2022-07-25T00:00:00.0000000' AS DateTime2), N' ', N' ')
GO
SET IDENTITY_INSERT [dbo].[PoHeaders] OFF
GO
SET IDENTITY_INSERT [dbo].[ProductGroups] ON 
GO
INSERT [dbo].[ProductGroups] ([Id], [Name], [Description]) VALUES (1, N'Tops', N'Tops')
GO
INSERT [dbo].[ProductGroups] ([Id], [Name], [Description]) VALUES (2, N'Bottoms', N'Bottoms')
GO
INSERT [dbo].[ProductGroups] ([Id], [Name], [Description]) VALUES (3, N'Fresh', N'Fresh')
GO
INSERT [dbo].[ProductGroups] ([Id], [Name], [Description]) VALUES (4, N'Frozen', N'Frozen')
GO
INSERT [dbo].[ProductGroups] ([Id], [Name], [Description]) VALUES (5, N'Desktops', N'Desktops')
GO
INSERT [dbo].[ProductGroups] ([Id], [Name], [Description]) VALUES (6, N'Tablets', N'Tablets')
GO
INSERT [dbo].[ProductGroups] ([Id], [Name], [Description]) VALUES (7, N'SmartPhones', N'SmartPhones')
GO
INSERT [dbo].[ProductGroups] ([Id], [Name], [Description]) VALUES (8, N'Laptops', N'Laptops')
GO
INSERT [dbo].[ProductGroups] ([Id], [Name], [Description]) VALUES (9, N'Printers', N'Printers')
GO
INSERT [dbo].[ProductGroups] ([Id], [Name], [Description]) VALUES (10, N'Beverage Items', N'Beverage Items')
GO
SET IDENTITY_INSERT [dbo].[ProductGroups] OFF
GO
SET IDENTITY_INSERT [dbo].[ProductProfiles] ON 
GO
INSERT [dbo].[ProductProfiles] ([Id], [Name], [Description]) VALUES (1, N'Men', N'MensWear')
GO
INSERT [dbo].[ProductProfiles] ([Id], [Name], [Description]) VALUES (2, N'Ladies', N'LadiesWear')
GO
INSERT [dbo].[ProductProfiles] ([Id], [Name], [Description]) VALUES (3, N'Kids', N'Kidswear')
GO
INSERT [dbo].[ProductProfiles] ([Id], [Name], [Description]) VALUES (4, N'Footwear', N'Footwear')
GO
INSERT [dbo].[ProductProfiles] ([Id], [Name], [Description]) VALUES (5, N'NightWear', N'NightWear')
GO
INSERT [dbo].[ProductProfiles] ([Id], [Name], [Description]) VALUES (6, N'Food Items', N'Food Items')
GO
INSERT [dbo].[ProductProfiles] ([Id], [Name], [Description]) VALUES (7, N'Cleaning Items', N'Cleaning Items')
GO
INSERT [dbo].[ProductProfiles] ([Id], [Name], [Description]) VALUES (8, N'Electronics', N'Electronics')
GO
SET IDENTITY_INSERT [dbo].[ProductProfiles] OFF
GO
INSERT [dbo].[Products] ([Code], [Name], [Description], [Cost], [Price], [UnitId], [BrandId], [CategoryId], [ProductGroupId], [ProductProfileId], [PhotoUrl]) VALUES (N'CD0001', N'Fanta  small', N'Fanta small', 3.0000, 10.0000, 47, 1, 14, 10, 6, N'images\ff74a651-48fa-402a-acbb-0fbfcb21f0ba_noimage.png')
GO
INSERT [dbo].[Products] ([Code], [Name], [Description], [Cost], [Price], [UnitId], [BrandId], [CategoryId], [ProductGroupId], [ProductProfileId], [PhotoUrl]) VALUES (N'GR0001', N'Red Checked Shirt', N'Red Checked Shirt', 450.0000, 1000.0000, 44, 4, 6, 1, 1, N'images\dfdcaab0-452c-4951-bd4b-240944c97d82_CheckedShirt.jpg')
GO
INSERT [dbo].[Products] ([Code], [Name], [Description], [Cost], [Price], [UnitId], [BrandId], [CategoryId], [ProductGroupId], [ProductProfileId], [PhotoUrl]) VALUES (N'GR0002', N'Black Shirt', N'Black Shirt', 300.0000, 500.0000, 44, 4, 11, 1, 1, N'images\8fb9d234-0d1f-469f-909c-46e6ad7a9d8e_BlackShirt.jpg')
GO
INSERT [dbo].[Products] ([Code], [Name], [Description], [Cost], [Price], [UnitId], [BrandId], [CategoryId], [ProductGroupId], [ProductProfileId], [PhotoUrl]) VALUES (N'GR0003', N'Green Shirt', N'Green Shirt', 350.0000, 700.0000, 44, 4, 6, 1, 1, N'images\390ef5f7-5241-401b-9381-a4cc50de91a4_CheckedShirt.jpg')
GO
INSERT [dbo].[Products] ([Code], [Name], [Description], [Cost], [Price], [UnitId], [BrandId], [CategoryId], [ProductGroupId], [ProductProfileId], [PhotoUrl]) VALUES (N'GR0004', N'King Kohli Tshirts', N'King Kohli Tshirts', 500.0000, 1000.0000, 44, 4, 6, 1, 1, N'images\d65d6f86-1711-42a0-82b2-9778644637fc_KingKohli.jpg')
GO
INSERT [dbo].[Products] ([Code], [Name], [Description], [Cost], [Price], [UnitId], [BrandId], [CategoryId], [ProductGroupId], [ProductProfileId], [PhotoUrl]) VALUES (N'GR0005', N'Mr.Cool Tshirts', N'Mr.Cool Tshirts', 600.0000, 1200.0000, 44, 4, 6, 1, 1, N'images\9a0b8232-2f54-438d-b033-efefbe8462ca_captaincool.jpg')
GO
SET IDENTITY_INSERT [dbo].[Suppliers] ON 
GO
INSERT [dbo].[Suppliers] ([Id], [Code], [Name], [EmailId], [Address], [PhoneNo]) VALUES (1, N'SP0001', N'XYZ Garments', N'xyz@xyz.com', N'P.O Box no 12345
Dubai
UAE
', N'633389448')
GO
INSERT [dbo].[Suppliers] ([Id], [Code], [Name], [EmailId], [Address], [PhoneNo]) VALUES (2, N'SP0002', N'ARL Enterprises', N'arl@codesbyaniz.com', N'North west road,
Mumbai,
India', N'76448945545490')
GO
INSERT [dbo].[Suppliers] ([Id], [Code], [Name], [EmailId], [Address], [PhoneNo]) VALUES (3, N'SP0003', N'PP International Garments', N'pp@ppinternational.com', N'Mahatma Gandhi road,
Tirupur.
Tamil Nadu,
India', N'5677390445')
GO
INSERT [dbo].[Suppliers] ([Id], [Code], [Name], [EmailId], [Address], [PhoneNo]) VALUES (4, N'SP0004', N'ABC Garments', N'contactus@abc.com', N'Delhi,
India', N'646495985090')
GO
INSERT [dbo].[Suppliers] ([Id], [Code], [Name], [EmailId], [Address], [PhoneNo]) VALUES (5, N'SP0005', N'Aniz Softwares & Services', N'aniz@aniz.com', N'Po No 12345, Dubai , UAE', N'3456778899223')
GO
INSERT [dbo].[Suppliers] ([Id], [Code], [Name], [EmailId], [Address], [PhoneNo]) VALUES (6, N'SP0008', N'Aniz Garments', N'123@123.com', N'India', N'3563445856858')
GO
INSERT [dbo].[Suppliers] ([Id], [Code], [Name], [EmailId], [Address], [PhoneNo]) VALUES (7, N'SP0009', N'Aniz Textiles & Garments', N'aniz1@aniz.com', N'Dubai , UAE, Earth', N'5637475262567')
GO
SET IDENTITY_INSERT [dbo].[Suppliers] OFF
GO
SET IDENTITY_INSERT [dbo].[Units] ON 
GO
INSERT [dbo].[Units] ([Id], [Name], [Description]) VALUES (8, N'g', N'Grams')
GO
INSERT [dbo].[Units] ([Id], [Name], [Description]) VALUES (9, N'mg', N'Milli Gram')
GO
INSERT [dbo].[Units] ([Id], [Name], [Description]) VALUES (11, N'4Pcs', N'4 Pcs Set')
GO
INSERT [dbo].[Units] ([Id], [Name], [Description]) VALUES (12, N'5 Pcs Set', N'5 Pcs Set')
GO
INSERT [dbo].[Units] ([Id], [Name], [Description]) VALUES (15, N'ml', N'Milli Liter')
GO
INSERT [dbo].[Units] ([Id], [Name], [Description]) VALUES (16, N'dl', N'Deci Liter')
GO
INSERT [dbo].[Units] ([Id], [Name], [Description]) VALUES (18, N'mm', N'Milli Meter')
GO
INSERT [dbo].[Units] ([Id], [Name], [Description]) VALUES (19, N'cm', N'Centi Meter')
GO
INSERT [dbo].[Units] ([Id], [Name], [Description]) VALUES (20, N'km', N'Kilo Meter')
GO
INSERT [dbo].[Units] ([Id], [Name], [Description]) VALUES (23, N'4 pair', N'4 pair')
GO
INSERT [dbo].[Units] ([Id], [Name], [Description]) VALUES (24, N'2 pair', N'2 pairs')
GO
INSERT [dbo].[Units] ([Id], [Name], [Description]) VALUES (26, N'Pkt', N'Packets')
GO
INSERT [dbo].[Units] ([Id], [Name], [Description]) VALUES (30, N'1kg pkt', N'1kg packet')
GO
INSERT [dbo].[Units] ([Id], [Name], [Description]) VALUES (31, N'3Pcs', N'3 Pieces set')
GO
INSERT [dbo].[Units] ([Id], [Name], [Description]) VALUES (32, N'3 Pair', N'3 Pair')
GO
INSERT [dbo].[Units] ([Id], [Name], [Description]) VALUES (33, N'litre', N'litres')
GO
INSERT [dbo].[Units] ([Id], [Name], [Description]) VALUES (34, N'Bottles', N'Bottles')
GO
INSERT [dbo].[Units] ([Id], [Name], [Description]) VALUES (36, N'2Pcs', N'2Pieces Set')
GO
INSERT [dbo].[Units] ([Id], [Name], [Description]) VALUES (37, N'2SACHET', N'2SACHET')
GO
INSERT [dbo].[Units] ([Id], [Name], [Description]) VALUES (38, N'2KgPkt', N'2Kg packets')
GO
INSERT [dbo].[Units] ([Id], [Name], [Description]) VALUES (39, N'sachet', N'sachet')
GO
INSERT [dbo].[Units] ([Id], [Name], [Description]) VALUES (40, N'mtr', N'rmeter')
GO
INSERT [dbo].[Units] ([Id], [Name], [Description]) VALUES (41, N'kg', N'kilogram')
GO
INSERT [dbo].[Units] ([Id], [Name], [Description]) VALUES (44, N'Pcs', N'Pieces')
GO
INSERT [dbo].[Units] ([Id], [Name], [Description]) VALUES (45, N'5pcsPack', N'5 Pieces bundle')
GO
INSERT [dbo].[Units] ([Id], [Name], [Description]) VALUES (46, N'Nos', N'Numbers')
GO
INSERT [dbo].[Units] ([Id], [Name], [Description]) VALUES (47, N'Can', N'Cans')
GO
SET IDENTITY_INSERT [dbo].[Units] OFF
GO
*/

ALTER TABLE [dbo].[QuyenVaiTro]  WITH CHECK ADD  CONSTRAINT [FK_QuyenVaiTro_VaiTro_MaVaiTro] FOREIGN KEY([MaVaiTro])
REFERENCES [dbo].[VaiTro] ([MaVaiTro])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[QuyenVaiTro] CHECK CONSTRAINT [FK_QuyenVaiTro_VaiTro_MaVaiTro]
GO

ALTER TABLE [dbo].[QuyenNguoiDung]  WITH CHECK ADD  CONSTRAINT [FK_QuyenNguoiDung_NguoiDung_MaNguoiDung] FOREIGN KEY([MaNguoiDung])
REFERENCES [dbo].[NguoiDung] ([MaNguoiDung])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[QuyenNguoiDung] CHECK CONSTRAINT [FK_QuyenNguoiDung_NguoiDung_MaNguoiDung]
GO

ALTER TABLE [dbo].[ThongTinDangNhap]  WITH CHECK ADD  CONSTRAINT [FK_ThongTinDangNhap_NguoiDung_MaNguoiDung] FOREIGN KEY([MaNguoiDung])
REFERENCES [dbo].[NguoiDung] ([MaNguoiDung])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ThongTinDangNhap] CHECK CONSTRAINT [FK_ThongTinDangNhap_NguoiDung_MaNguoiDung]
GO

ALTER TABLE [dbo].[VaiTroNguoiDung]  WITH CHECK ADD  CONSTRAINT [FK_VaiTroNguoiDung_VaiTro_MaVaiTro] FOREIGN KEY([MaVaiTro])
REFERENCES [dbo].[VaiTro] ([MaVaiTro])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[VaiTroNguoiDung] CHECK CONSTRAINT [FK_VaiTroNguoiDung_VaiTro_MaVaiTro]
GO

ALTER TABLE [dbo].[VaiTroNguoiDung]  WITH CHECK ADD  CONSTRAINT [FK_VaiTroNguoiDung_NguoiDung_MaNguoiDung] FOREIGN KEY([MaNguoiDung])
REFERENCES [dbo].[NguoiDung] ([MaNguoiDung])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[VaiTroNguoiDung] CHECK CONSTRAINT [FK_VaiTroNguoiDung_NguoiDung_MaNguoiDung]
GO

ALTER TABLE [dbo].[TokenNguoiDung]  WITH CHECK ADD  CONSTRAINT [FK_TokenNguoiDung_NguoiDung_MaNguoiDung] FOREIGN KEY([MaNguoiDung])
REFERENCES [dbo].[NguoiDung] ([MaNguoiDung])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TokenNguoiDung] CHECK CONSTRAINT [FK_TokenNguoiDung_NguoiDung_MaNguoiDung]
GO

ALTER TABLE [dbo].[TienTe]  WITH CHECK ADD  CONSTRAINT [FK_TienTe_TienTe_MaTraoDoiTienTe] FOREIGN KEY([MaTraoDoiTienTe])
REFERENCES [dbo].[TienTe] ([MaTienTe])
GO
ALTER TABLE [dbo].[TienTe] CHECK CONSTRAINT [FK_TienTe_TienTe_MaTraoDoiTienTe]
GO

ALTER TABLE [dbo].[ChiTietDonHang] WITH CHECK ADD CONSTRAINT [FK_ChiTietDonHang_DonHang_MaDonHang] FOREIGN KEY([MaDonHang])
REFERENCES [dbo].[DonHang] ([MaDonHang])
ON DELETE NO ACTION;
ALTER TABLE [dbo].[ChiTietDonHang] CHECK CONSTRAINT [FK_ChiTietDonHang_DonHang_MaDonHang];

ALTER TABLE [dbo].[ChiTietDonHang]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietDonHang_SanPham_MaSP] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ChiTietDonHang] CHECK CONSTRAINT [FK_ChiTietDonHang_SanPham_MaSP]
GO

ALTER TABLE [dbo].[DonHang]  WITH CHECK ADD  CONSTRAINT [FK_DonHang_TienTe_MaTienTeCoSo] FOREIGN KEY([MaTienTeCoSo])
REFERENCES [dbo].[TienTe] ([MaTienTe])
GO
ALTER TABLE [dbo].[DonHang] CHECK CONSTRAINT [FK_DonHang_TienTe_MaTienTeCoSo]
GO

ALTER TABLE [dbo].[DonHang]  WITH CHECK ADD  CONSTRAINT [FK_DonHang_TienTe_MaTienTeDonHang] FOREIGN KEY([MaTienTeDonHang])
REFERENCES [dbo].[TienTe] ([MaTienTe])
GO
ALTER TABLE [dbo].[DonHang] CHECK CONSTRAINT [FK_DonHang_TienTe_MaTienTeDonHang]
GO

ALTER TABLE [dbo].[DonHang]  WITH CHECK ADD  CONSTRAINT [FK_DonHang_NhaCungCap_MaNCC] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungCap] ([MaNCC])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DonHang] CHECK CONSTRAINT [FK_DonHang_NhaCungCap_MaNCC]
GO

ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_ThuongHieu_MaThuongHieu] FOREIGN KEY([MaThuongHieu])
REFERENCES [dbo].[ThuongHieu] ([MaThuongHieu])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_ThuongHieu_MaThuongHieu]
GO

ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_DanhMuc_MaDanhMuc] FOREIGN KEY([MaDanhMuc])
REFERENCES [dbo].[DanhMuc] ([MaDanhMuc])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_DanhMuc_MaDanhMuc]
GO

ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_NhomSP_MaNhomSP] FOREIGN KEY([MaNhomSP])
REFERENCES [dbo].[NhomSP] ([MaNhomSP])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_NhomSP_MaNhomSP]
GO

ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_HoSoSP_MaHoSoSP] FOREIGN KEY([MaHoSoSP])
REFERENCES [dbo].[HoSoSP] ([MaHoSoSP])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_HoSoSP_MaHoSoSP]
GO

ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_DonVi_MaDonVi] FOREIGN KEY([MaDonVi])
REFERENCES [dbo].[DonVi] ([MaDonVi])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_DonVi_MaDonVi]
GO
