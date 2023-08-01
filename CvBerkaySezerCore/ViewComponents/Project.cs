using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CvBerkaySezerCore.ViewComponents
{
	public class Project : ViewComponent
	{
		ProjectManager projectManager = new ProjectManager(new EfProjectDal());

		public IViewComponentResult Invoke()
		{
			var projects = projectManager.GetAll(x => x.IsDeleted == false).OrderByDescending(x => x.Id).ToList();
			return View(projects);
		}
	}
}
