using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CvBerkaySezerCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DefaultController : Controller
    {
        private readonly string header = "Ana Sayfa";

        public IActionResult Index()
        {
            ViewBag.Header = header;

            ServiceManager service = new ServiceManager(new EfServiceDal());
            ViewBag.Service = service.TGetAll().Count;

            SkillManager skill = new SkillManager(new EfSkillDal());
            ViewBag.Skill = skill.TGetAll(x => x.IsDeleted == false).Count;

            ProjectManager project = new ProjectManager(new EfProjectDal());
            ViewBag.Project = project.TGetAll(x => x.IsDeleted == false).Count;

            ContactManager message = new ContactManager(new EfContactDal());
            ViewBag.Message = message.TGetAll(x => x.IsDeleted == false && x.IsRead == false).Count;

            //ClientRepository client = new ClientRepository();
            //ViewBag.Client = client.List(x => x.IsDeleted == false).Count;

            return View();
        }
    }
}
