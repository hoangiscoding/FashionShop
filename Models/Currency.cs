namespace FashionShop.Models
{
    public class Currency
    {
        [Key]
        public string MaTienTe { get; set; }

        [Required]
        [StringLength(50)]
        public string TenTienTe { get; set; }

        [Required]
        [StringLength(100)]
        public string MoTa { get; set; }

        
        [ForeignKey("TienTe")]
        public string? MaTraoDoiTienTe { get; set; }

        public virtual Currency TienTe { get; set; }



        [DisplayFormat(DataFormatString = "{0:0.000}",ApplyFormatInEditMode =true)]
        [Column(TypeName ="money")]
        [Required]
        public decimal TyGiaHoiDoai { get; set; }    
    }
}
