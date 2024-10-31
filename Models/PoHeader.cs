namespace FashionShop.Models
{
    public class DonHang
    {
        [Key]
        public string MaDonHang { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime NgayTao { get; set; } = DateTime.Now.Date;


        [Required]
        [ForeignKey("Supplier")]
        public string MaNCC { get; set; }

        public virtual Supplier Supplier { get; private set; }

        [ForeignKey("BaseCurrency")]
        [Required]
        public string MaTienTeCoSo { get; set; }
        public virtual Currency BaseCurrency { get; private set; }


        [ForeignKey("POCurrency")]
        [Required]
        public string MaTienTeDonHang { get; set; }
        public virtual Currency POCurrency { get; private set; }

        [DisplayFormat(DataFormatString = "{0:0.000}", ApplyFormatInEditMode = true)]
        [Column(TypeName = "smallmoney")]
        [Required]
        public decimal TyGiaHoiDoai { get; set; }

        [Required]
        public int GiamGia { get; set; }


        [Required]
        [MaxLength(50)]
        public string MaBaoGia { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime NgayBaoGia { get; set; }=  DateTime.Now.Date;



        [Required]
        [MaxLength(500)]
        public string DieuKhoanThanhToan { get; set; } = " ";

        [Required]
        [MaxLength(500)]
        public string GhiChu { get; set; } = " ";

        public virtual List<PoDetail> ChiTietDonHang { get; set; } =new List<PoDetail>();        


    }
}
