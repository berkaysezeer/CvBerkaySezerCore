using Microsoft.AspNetCore.Mvc;

namespace CvBerkaySezerCore.ViewComponents
{
    public class Experience : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
