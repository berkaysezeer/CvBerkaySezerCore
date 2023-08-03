using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using FluentValidation.Validators;
using System.Linq;
using FluentValidation.Results;

namespace CvBerkaySezerCore.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class HeaderController : Controller
	{
		HeaderManager headerManager = new HeaderManager(new EfHeaderDal());
        private readonly string head = "Başlık";

        [HttpGet]
		public IActionResult Index()
		{
            ViewBag.Header = head;
            var header = headerManager.TGetAll().FirstOrDefault();
			return View(header);
		}

		[HttpPost]
		public IActionResult Index(Header h)
		{
            ViewBag.Header = head;
			HeaderValidator validations = new HeaderValidator();
			ValidationResult result = validations.Validate(h); 

            var header = headerManager.TGetById(h.Id);

			if (result.IsValid)
			{
				header.Name = h.Name.Trim();
				header.Title = h.Title.Trim();
				header.Head = h.Head.Trim();

				headerManager.TUpdate(header);
			}
			else
			{
				foreach (var item in result.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
			}

			return View(header);
		}
	}
}
