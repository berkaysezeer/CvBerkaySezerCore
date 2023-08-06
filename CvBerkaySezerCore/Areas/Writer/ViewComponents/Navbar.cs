using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CvBerkaySezerCore.Areas.Writer.ViewComponents
{
    public class Navbar : ViewComponent
    {
        private readonly UserManager<WriterUser> _userManager;

        public Navbar(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var user = await _userManager.FindByNameAsync(HttpContext.User.Identity.Name);
            ViewBag.ImageUrl = user.ImageUrl;

            return View();
        }
    }
}
