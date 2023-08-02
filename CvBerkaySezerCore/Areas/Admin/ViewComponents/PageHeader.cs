using Microsoft.AspNetCore.Mvc;

namespace CvBerkaySezerCore.Areas.Admin.ViewComponents
{
	public class PageHeader : ViewComponent
	{
		public IViewComponentResult Invoke(string header)
		{
			ViewBag.Header = header;
			return View();
		}
	}
}
