namespace FashionShop.Models
{
    public class Unit
    {
        [Key]
        public string MaDonVi { get; set; }

        [Required]
        [StringLength(25)]
        public string TenDonVi { get; set; }

        [Required]
        [StringLength(75)]
        public string MoTa { get; set; }

    }
}
