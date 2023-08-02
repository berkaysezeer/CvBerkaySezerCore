using Microsoft.AspNetCore.Mvc;

namespace CvBerkaySezerCore.Areas.Admin.ViewComponents
{
	public class Navbar : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
