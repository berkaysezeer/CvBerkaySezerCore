using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CvBerkaySezerCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserMessage : Controller
    {
        UserMessageManager db = new UserMessageManager(new EfUserMessageDal());


        public IActionResult Index()
        {
            var messages = db.TGetUserMessages().OrderByDescending(x => x.Date).ToList();

            ViewBag.Header = "Kullanıcı Mesajları";
            return View(messages);
        }
    }
}
