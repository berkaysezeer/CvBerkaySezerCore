using CvBerkaySezerCore.Areas.Writer.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Threading.Tasks;

namespace CvBerkaySezerCore.Areas.Writer.Controllers
{
    [Authorize]
    [Area("Writer")]
    public class ProfileController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;

        public ProfileController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditViewModel userEditViewModel = new UserEditViewModel();
            userEditViewModel.FirstName = user.FirstName;
            userEditViewModel.LastName = user.LastName;
            userEditViewModel.Email = user.Email;
            userEditViewModel.ImageUrl = user.ImageUrl;
            userEditViewModel.Password = user.PasswordHash;

            return View(userEditViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserEditViewModel u)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditViewModel userEditViewModel = new UserEditViewModel();
            userEditViewModel.FirstName = user.FirstName;
            userEditViewModel.LastName = user.LastName;
            userEditViewModel.Email = user.Email;
            userEditViewModel.ImageUrl = user.ImageUrl;
            userEditViewModel.Password = user.PasswordHash;

            if (ModelState.IsValid)
            {
                if (u.Image != null)
                {
                    var resource = Directory.GetCurrentDirectory();
                    var ext = Path.GetExtension(u.Image.FileName);
                    var image = $"{Guid.NewGuid()}{ext}";
                    var saveLocation = $"{resource}/wwwroot/Images/User/{image}";
                    var stream = new FileStream(saveLocation, FileMode.Create);

                    await u.Image.CopyToAsync(stream);
                    user.ImageUrl = $"/Images/User/{image}";
                }

                user.FirstName = u.FirstName;
                user.LastName = u.LastName;
                user.Email = u.Email;
                user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, u.Password);

                var result = await _userManager.UpdateAsync(user);

                if (result.Succeeded) return RedirectToAction("Index", "Default", new { area = "Writer" });
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }

            }

            return View(userEditViewModel);
        }
    }
}
