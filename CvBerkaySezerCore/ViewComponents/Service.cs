using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CvBerkaySezerCore.ViewComponents
{
	public class Service : ViewComponent
	{
		ServiceManager serviceManager = new ServiceManager(new EfServiceDal());
		public IViewComponentResult Invoke()
		{
			var service = serviceManager.TGetAll().FirstOrDefault();
			return View(service);
		}
	}
}
