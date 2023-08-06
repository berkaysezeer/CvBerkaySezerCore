using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CvBerkaySezerCore.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Authorize]
    public class DefaultController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;

        public DefaultController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        AnnouncementManager announcementManager = new AnnouncementManager(new EfAnnouncementDal());
        ProjectManager projectManager = new ProjectManager(new EfProjectDal());

        public async Task<IActionResult> Index()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.FullName = $"{user.FirstName} {user.LastName}";
            ViewBag.AnnouncementCount = announcementManager.TGetAll(x => x.IsDeleted == false).Count;
            ViewBag.MessageCount = "0";
            ViewBag.UserCount = "0";
            ViewBag.ProjectCount = projectManager.TGetAll(x => x.IsDeleted == false).Count;

            return View();
        }
    }
}
