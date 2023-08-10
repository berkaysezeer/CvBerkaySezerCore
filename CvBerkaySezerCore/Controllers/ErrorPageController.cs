using Microsoft.AspNetCore.Mvc;

namespace CvBerkaySezerCore.Controllers
{
	public class ErrorPageController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
