using Microsoft.AspNetCore.Mvc;

namespace CvBerkaySezerCore.ViewComponents
{
    public class About : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
