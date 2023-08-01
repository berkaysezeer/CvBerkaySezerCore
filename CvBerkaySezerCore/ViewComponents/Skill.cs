using Microsoft.AspNetCore.Mvc;

namespace CvBerkaySezerCore.ViewComponents
{
    public class Skill : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
