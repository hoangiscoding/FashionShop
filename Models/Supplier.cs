namespace FashionShop.Models
{
    public class Supplier
    {
        [Key]
        public string MaNCC { get; set; }

        [Required]
        [MaxLength(75)]
        public string TenNCC { get; set; } = "";        
        

        [Remote("IsEmailExists","Supplier",AdditionalFields="Id", ErrorMessage ="Email Already Exists")]
        [Required]
        [MaxLength(75)]
        [DataType(DataType.EmailAddress, ErrorMessage = "E-Mail is not Valid")]
        public string Email { get; set; } = "";

        [MaxLength(75)]
        public string DiaChi { get; set; } = "";

        [MaxLength(75)]
        public string SDT { get; set; } = "";
    }
}
