using Microsoft.AspNetCore.Mvc;

namespace CvBerkaySezerCore.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class DefaultController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
