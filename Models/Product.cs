namespace FashionShop.Models
{
    public class Product
    {
        [Remote("IsMaSPValid","Product", AdditionalFields ="Name", ErrorMessage ="Product Code Exists Already")]
        [Key]
        [StringLength(50)]
        public string MaSP { get; set; }

        [Remote("IsProductNameValid", "Product", AdditionalFields = "Code", ErrorMessage = "Product Name Exists Already")]
        [Required]
        [StringLength(75)]
        public String TenSP { get; set; }

        [Required]
        [StringLength(255)]
        public String MoTa { get; set; }

        [Required]         
        [Column(TypeName ="money")]
        public decimal DonGiaNhap { get; set; }

        [Required]
        [Column(TypeName = "money")]
        public decimal DonGiaBan { get; set; }

        [Required]
        [ForeignKey("DonVi")]
        [Display(Name="Unit")]
        public string MaDonVi { get; set; }
        public virtual Unit DonVi { get; set; }


        
        [ForeignKey("ThuongHieu")]
        [Display(Name = "Brand")]
        public string? MaThuongHieu { get; set; }
        public virtual Brand ThuongHieu { get; set; }


        [ForeignKey("DanhMuc")]
        [Display(Name = "Category")]
        public string? MaDanhMuc { get; set; }
        public virtual Category DanhMuc { get; set; }

        [ForeignKey("NhomSP")]
        [Display(Name = "ProductGroup")]
        public string? MaNhomSP { get; set; }
        public virtual ProductGroup NhomSP { get; set; }


        [ForeignKey("HoSoSP")]
        [Display(Name = "ProductProfile")]
        public string? MaHoSoSP { get; set; }
        public virtual ProductProfile HoSoSP { get; set; }

        public string Anh { get; set; } = "noimage.png";

        [Display(Name = "Product Photo")]
        [NotMapped]
        public IFormFile ProductPhoto { get; set; }

        [NotMapped]
        public string BreifPhotoName { get; set; }

    }
}
