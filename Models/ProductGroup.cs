namespace FashionShop.Models
{

    public class ProductGroup
    {
        [Key]
        public string MaNhomSP { get; set; }

        [Required]
        [StringLength(50)]
        public string TenNhom { get; set; }

        [Required]
        [StringLength(100)]
        public string MoTa { get; set; }

    }
}