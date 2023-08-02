using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CvBerkaySezerCore.ViewComponents
{
	public class Contact : ViewComponent
	{
		ContactManager contactManager = new ContactManager(new EfContactDal());

		[HttpGet]
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
