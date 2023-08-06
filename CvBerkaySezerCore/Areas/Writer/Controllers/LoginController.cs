using Microsoft.AspNetCore.Mvc;

namespace CvBerkaySezerCore.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
