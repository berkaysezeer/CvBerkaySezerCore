using BusinessLayer.Concrete;
using CvBerkaySezerCore.ViewModels;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace CvBerkaySezerCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class ProjectController : Controller
    {
        ProjectManager projectManager = new ProjectManager(new EfProjectDal());
        private readonly string header = "Projeler";

        public IActionResult Index()
        {
            ViewBag.Header = header;
            var projects = projectManager.TGetAll();
            return View(projects);
        }

        [HttpPost]
        public ActionResult Edit(Project p)
        {
            ViewBag.Header = header;
            var project = projectManager.TGetById(p.Id);

            if (ModelState.IsValid)
            {
                //if (Request.Files.Count > 0)
                //{
                //    string image = SaveImage.SaveProjectImage(Request, Server, p.Title.Replace(" ", ""));
                //    if (!string.IsNullOrEmpty(image)) project.ImageUrl = image;
                //}

                project.IsDeleted = p.IsDeleted;
                project.ProjectUrl = p.ProjectUrl.Trim();
                project.Title = p.Title.Trim();

                projectManager.TUpdate(project);

                TempData["ProjectMessage"] = "Proje başarıyla düzenlendi";
                TempData["ProjectType"] = "success";
            }
            else
            {
                TempData["ProjectMessage"] = "Proje düzenlenirken bir hata ile karşılaşıldı";
                TempData["ProjectType"] = "error";
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Add(AddProjectViewModel p)
        {
            ViewBag.Header = header;

            if (ModelState.IsValid)
            {
                //if (Request.Files.Count > 0)
                //{
                //    string image = SaveImage.SaveProjectImage(Request, Server, p.AddTitle.Replace(" ", ""));
                //    if (!string.IsNullOrEmpty(image)) p.AddImageUrl = image;
                //}

                Project project = new Project
                {
                    Title = p.AddTitle.Trim(),
                    ImageUrl = p.AddImageUrl.Trim(),
                    ProjectUrl = p.AddProjectUrl.Trim()
                };

                projectManager.TAdd(project);

                TempData["ProjectMessage"] = "Proje başarıyla eklendi";
                TempData["ProjectType"] = "success";
            }
            else
            {
                TempData["ProjectMessage"] = "Proje düzenlenirken bir hata ile karşılaşıldı";
                TempData["ProjectType"] = "error";
            }

            return RedirectToAction("Index");
        }
    }
}
