namespace FashionShop.Models
{

    public class Category
    {
        [Key]
        public string MaDanhMuc { get; set; }

        [Required]
        [StringLength(50)]
        public string TenDanhMuc { get; set; }

        [Required]
        [StringLength(100)]
        public string MoTa { get; set; }

    }
}