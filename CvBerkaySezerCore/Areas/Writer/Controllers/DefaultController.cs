using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
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
        WriterMessageManager messageManager = new WriterMessageManager(new EfWriterMessageDal());

        public async Task<IActionResult> Index()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.FullName = $"{user.FirstName} {user.LastName}";

            ViewBag.AnnouncementCount = announcementManager.TGetAll(x => x.IsDeleted == false).Count;
            ViewBag.MessageCount = messageManager.TGetReceiverMessage(user.Email).Count;
            ViewBag.UserCount = _userManager.Users.Count();
            ViewBag.ProjectCount = projectManager.TGetAll(x => x.IsDeleted == false).Count;

            return View();
        }
    }
}
