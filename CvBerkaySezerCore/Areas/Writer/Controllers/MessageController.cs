using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CvBerkaySezerCore.Areas.Writer.Controllers
{
    [Authorize]
    [Area("Writer")]
    public class MessageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
