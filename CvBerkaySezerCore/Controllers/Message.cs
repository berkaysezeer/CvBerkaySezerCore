using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CvBerkaySezerCore.Controllers
{
	public class Message : Controller
	{
		ContactManager contactManager = new ContactManager(new EfContactDal());

		[HttpPost]
		public IActionResult Add(Contact c)
		{
			c.Date = DateTime.Now;
			if (ModelState.IsValid) contactManager.TAdd(c);
			return RedirectToAction("Index", "Default");
		}
	}
}
