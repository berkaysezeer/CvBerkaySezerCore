using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CvBerkaySezerCore.Areas.Admin.ViewComponents
{
	public class DashboardProject : ViewComponent
	{
		ProjectManager db = new ProjectManager(new EfProjectDal());
		public IViewComponentResult Invoke()
		{
			var project = db.TGetAll(x => x.IsDeleted == false).OrderByDescending(x => x.Id).Take(5).ToList();
			return View(project);
		}
	}
}
