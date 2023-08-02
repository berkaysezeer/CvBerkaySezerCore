using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CvBerkaySezerCore.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class HeaderController : Controller
	{
		HeaderManager headerManager = new HeaderManager(new EfHeaderDal());

		[HttpGet]
		public IActionResult Index()
		{
			var header = headerManager.TGetAll().FirstOrDefault();
			return View(header);
		}

		[HttpPost]
		public IActionResult Index(Header h)
		{
			var header = headerManager.TGetById(h.Id);

			if (ModelState.IsValid)
			{
				header.Name = h.Name.Trim();
				header.Title = h.Title.Trim();
				header.Head = h.Head.Trim();

				headerManager.TUpdate(header);
			}

			return View(header);
		}
	}
}
