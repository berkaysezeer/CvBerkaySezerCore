using Microsoft.AspNetCore.Mvc;

namespace CvBerkaySezerCore.ViewComponents
{
    public class ServiceImage : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
