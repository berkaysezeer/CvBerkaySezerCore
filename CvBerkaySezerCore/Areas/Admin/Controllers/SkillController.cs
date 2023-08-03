using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using CvBerkaySezerCore.ViewModels;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using FluentValidation.Results;

namespace CvBerkaySezerCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SkillController : Controller
    {
        SkillManager skillManager = new SkillManager(new EfSkillDal());

        private readonly string header = "Yetenekler";

        public IActionResult Index()
        {
            ViewBag.Header = header;
            var skills = skillManager.TGetAll();
            return View(skills);
        }

        [HttpPost]
        public IActionResult Edit(Skill s)
        {
            ViewBag.Header = header;
            var skill = skillManager.TGetById(s.Id);

            SkillValidator validations = new SkillValidator();
            ValidationResult result = validations.Validate(skill);


			if (result.IsValid)
            {
                skill.IsDeleted = s.IsDeleted;
                skill.Title = s.Title.Trim();
                skill.Rate = s.Rate;
                skillManager.TUpdate(skill);

                TempData["SkillMessage"] = "Yetenek başarıyla düzenlendi";
                TempData["SkillType"] = "success";
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }

                TempData["SkillMessage"] = "Yetenek düzenlenirken bir hata ile karşılaşıldı";
                TempData["SkillType"] = "error";
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Add(AddSkillViewModel s)
        {
			Skill skill = new Skill
			{
				Title = s.AddTitle.Trim(),
				Rate = s.AddRate
			};

			ViewBag.Header = header;
            SkillValidator validations = new SkillValidator();
            ValidationResult result = validations.Validate(skill);

            if (result.IsValid)
            {              
                skillManager.TAdd(skill);

                TempData["SkillMessage"] = "Yetenek başarıyla eklendi";
                TempData["SkillType"] = "success";
            }
            else
            {
				foreach (var item in result.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}

				TempData["ServiceMessage"] = "Yetenek düzenlenirken bir hata ile karşılaşıldı";
                TempData["ServiceType"] = "error";
            }

            return RedirectToAction("Index");
        }
    }
}
