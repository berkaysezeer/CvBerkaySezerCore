using CvBerkaySezerCore.Areas.Writer.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CvBerkaySezerCore.Areas.Writer.Controllers
{

    [AllowAnonymous]
    [Area("Writer")]
    public class LoginController : Controller
    {
        private readonly SignInManager<WriterUser> _signInManager;

        public LoginController(SignInManager<WriterUser> signInManager)
        {
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserLoginViewModel u)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(u.UserName, u.Password, true, true);

                if (result.Succeeded) return RedirectToAction("Index", "Default", new { area = "Writer" });
                else
                {
                    ModelState.AddModelError("", "Kullanıcı adı veya şifre hatalı");
                }
            }

            return View();
        }
    }
}
