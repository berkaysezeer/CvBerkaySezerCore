using Microsoft.AspNetCore.Mvc;

namespace CvBerkaySezerCore.Areas.Admin.ViewComponents
{
	public class Dashboard : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
