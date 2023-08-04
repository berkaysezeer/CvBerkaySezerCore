using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CvBerkaySezerCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DefaultController : Controller
    {
        private readonly string header = "Ana Sayfa";

        public IActionResult Index()
        {
            ViewBag.Header = header;

            return View();
        }
    }
}
