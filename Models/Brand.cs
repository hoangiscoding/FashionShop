namespace FashionShop.Models
{
    public class Brand
    {
        [Key]
        public string MaThuongHieu { get; set; }

        [Required]
        [StringLength(50)]
        public string TenThuongHieu { get; set; }

        [Required]
        [StringLength(100)]
        public string MoTa { get; set; }

    }
}
