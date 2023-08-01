using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CvBerkaySezerCore.ViewComponents
{
    public class Header : ViewComponent
    {
        HeaderManager headerManager = new HeaderManager(new EfHeaderDal());

        public IViewComponentResult Invoke()
        {
            var header = headerManager.TGetAll().FirstOrDefault();
            return View(header);
        }
    }
}
