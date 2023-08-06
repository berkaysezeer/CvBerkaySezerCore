using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CvBerkaySezerCore.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Authorize]
    public class AnnouncementController : Controller
    {
        AnnouncementManager db = new AnnouncementManager(new EfAnnouncementDal());
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Detail(int Id)
        {
            var announcement = db.TGetById(Id);
            return View(announcement);
        }
    }
}
