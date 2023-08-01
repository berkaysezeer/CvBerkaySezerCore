using Microsoft.AspNetCore.Mvc;

namespace CvBerkaySezerCore.ViewComponents
{
    public class Testimonial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
