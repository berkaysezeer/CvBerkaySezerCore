using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CvBerkaySezerCore.Controllers
{
	[AllowAnonymous]
	public class Message : Controller
	{
		ContactManager contactManager = new ContactManager(new EfContactDal());

		[HttpPost]
		public IActionResult Add(Contact c)
		{
			c.Date = DateTime.Now;

			ContactValidator validations = new ContactValidator();
			ValidationResult result = validations.Validate(c);

			if (result.IsValid)
			{
				contactManager.TAdd(c);
			}

			return RedirectToAction("Index", "Default");
		}
	}
}
