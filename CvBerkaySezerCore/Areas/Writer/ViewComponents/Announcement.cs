using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CvBerkaySezerCore.Areas.Writer.ViewComponents
{
    public class Announcement : ViewComponent
    {
        AnnouncementManager db = new AnnouncementManager(new EfAnnouncementDal());
        public IViewComponentResult Invoke()
        {
            var announcements = db.TGetAll(x => x.IsDeleted == false).OrderByDescending(x=>x.Date).ToList();
            return View(announcements);
        }
    }
}
