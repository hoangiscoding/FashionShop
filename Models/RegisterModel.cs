using Microsoft.AspNetCore.Mvc;
using FashionShop.Areas.Identity;
using FashionShop.Models;

namespace FashionShop.Models
{
    public class RegisterViewModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}//

