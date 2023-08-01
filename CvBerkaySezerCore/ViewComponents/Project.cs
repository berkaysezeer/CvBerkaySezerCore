using Microsoft.AspNetCore.Mvc;

namespace CvBerkaySezerCore.ViewComponents
{
    public class Project : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
