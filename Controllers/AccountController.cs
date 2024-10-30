using FashionShop.Areas.Identity;
using FashionShop.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FashionShop.Controllers
{
    public class AccountController : Controller
    {
        private readonly IEmailSender _emailSender;
        private readonly UserManager<IdentityUser> _userManager;

        public AccountController(IEmailSender emailSender, UserManager<IdentityUser> userManager)
        {
            _emailSender = emailSender;
            _userManager = userManager;
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser { UserName = model.Email, Email = model.Email };
                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    var callbackUrl = Url.Action("ConfirmEmail", "Account", new { userId = user.Id, code = code }, protocol: HttpContext.Request.Scheme);
                    await _emailSender.SendEmailAsync(model.Email, "Confirm your email",
                        $"Please confirm your account by <a href='{callbackUrl}'>clicking here</a>.");

                    return RedirectToAction("Index", "Home");
                }
                AddErrors(result);
            }

            return View(model);
        }

        private void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
        }
    }
}//