using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace CvBerkaySezerCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
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
