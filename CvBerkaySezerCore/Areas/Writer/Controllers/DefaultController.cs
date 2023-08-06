using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CvBerkaySezerCore.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Authorize]
    [Route("Writer/[controller]/[action]")]
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
