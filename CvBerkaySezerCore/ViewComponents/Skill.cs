using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CvBerkaySezerCore.ViewComponents
{
    public class Skill : ViewComponent
    {
        SkillManager skillManager = new SkillManager(new EfSkillDal());
        public IViewComponentResult Invoke()
        {
            var skills = skillManager.TGetAll(x => x.IsDeleted == false);
            return View(skills);
        }
    }
}
