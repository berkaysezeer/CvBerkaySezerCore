using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CvBerkaySezerCore.ViewComponents
{
	public class Experience : ViewComponent
	{
		ExperienceManager expreienceManager = new ExperienceManager(new EfExperienceDal());
		public IViewComponentResult Invoke()
		{
			var experiences = expreienceManager.TGetAll(x => x.IsDeleted == false).OrderByDescending(x => x.Id).ToList();
			return View(experiences);
		}
	}
}
