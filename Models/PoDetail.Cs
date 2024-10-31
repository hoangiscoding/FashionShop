namespace FashionShop.Models
{
    public class PoDetail
    {
        [Key]
        public string MaChiTietDonHang { get; set; }

        [Required]
        [ForeignKey("DonHang")]
        public string MaDonHang { get; set; }
        public virtual DonHang DonHang { get; private set; }

        [Required]
        [ForeignKey("Product")]
        [MaxLength(50)]
        public string MaSP { get; set; }

        public virtual Product  Product { get; private set; }

        [Column(TypeName = "money")]
        [Required]
        [Range(1,1000,ErrorMessage ="SoLuong should be greater than 0 and less than 1000")]
        public decimal SoLuong { get; set; }


        [Range(1, 10000000, ErrorMessage = "FOB should be greater than 0")]
        [DisplayFormat(DataFormatString = "{0:0.000}", ApplyFormatInEditMode = true)]
        [Column(TypeName = "smallmoney")]
        [Required]
        public decimal Fob { get; set; }

        [Range(1, 10000000, ErrorMessage = "DonGiaBan should be greater than 0")]
        [DisplayFormat(DataFormatString = "{0:0.000}", ApplyFormatInEditMode = true)]
        [Column(TypeName = "smallmoney")]
        [Required]
        public decimal PrcInBaseCur { get; set; }
        
        [MaxLength(75)]
        [NotMapped]
        public string MoTa { get; set; } = "";

        [MaxLength(25)]
        [NotMapped]
        public string UnitName { get; set; } = "Pcs";

        [NotMapped]
        public bool IsDeleted { get; set; } = false;
        [NotMapped]
        public decimal Total { get; set; }
    }
}
