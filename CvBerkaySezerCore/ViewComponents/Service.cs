using Microsoft.AspNetCore.Mvc;

namespace CvBerkaySezerCore.ViewComponents
{
    public class Service : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
