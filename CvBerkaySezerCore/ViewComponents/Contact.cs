using Microsoft.AspNetCore.Mvc;

namespace CvBerkaySezerCore.ViewComponents
{
    public class Contact : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
