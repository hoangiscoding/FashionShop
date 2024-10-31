namespace FashionShop.Models
{

    public class ProductProfile
    {
        [Key]
        public string MaHoSoSP { get; set; }

        [Required]
        [StringLength(25)]
        public string TenHoSoSP { get; set; }

        [Required]
        [StringLength(75)]
        public string MoTa { get; set; }

    }
}
