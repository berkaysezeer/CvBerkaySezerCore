using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CvBerkaySezerCore.ViewComponents
{
	public class ServiceImage : ViewComponent
	{
		ServiceImageManager serviceImageManager = new ServiceImageManager(new EfServiceImageDal());
		public IViewComponentResult Invoke()
		{
			var serviceImages = serviceImageManager.TGetAll(x => x.IsDeleted == false).OrderByDescending(x => x.Id).ToList();
			return View(serviceImages);
		}
	}
}
