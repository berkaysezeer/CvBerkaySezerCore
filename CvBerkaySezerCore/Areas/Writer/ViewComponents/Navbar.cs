using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.Migrations;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
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

        AnnouncementManager announcement = new AnnouncementManager(new EfAnnouncementDal());

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var user = await _userManager.FindByNameAsync(HttpContext.User.Identity.Name);
            ViewBag.ImageUrl = user.ImageUrl;

            var ann = announcement.TGetAll(x => x.IsDeleted == false).Take(5).OrderByDescending(x => x.Date).ToList();

            return View(ann);
        }
    }
}
