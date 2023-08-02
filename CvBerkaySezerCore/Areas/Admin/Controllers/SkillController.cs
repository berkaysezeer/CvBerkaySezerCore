using BusinessLayer.Concrete;
using CvBerkaySezerCore.ViewModels;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace CvBerkaySezerCore.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class SkillController : Controller
	{
		SkillManager skillManager = new SkillManager(new EfSkillDal());

		public IActionResult Index()
		{
			var skills = skillManager.TGetAll();
			return View(skills);
		}

		[HttpPost]
		public IActionResult Edit(Skill s)
		{
			var skill = skillManager.TGetById(s.Id);

			if (ModelState.IsValid)
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
				TempData["SkillMessage"] = "Yetenek düzenlenirken bir hata ile karşılaşıldı";
				TempData["SkillType"] = "error";
			}


			return RedirectToAction("Index");
		}

		[HttpPost]
		public IActionResult Add(AddSkillViewModel s)
		{
			if (ModelState.IsValid)
			{
				Skill skill = new Skill
				{
					Title = s.AddTitle.Trim(),
					Rate = s.AddRate
				};

				skillManager.TAdd(skill);

				TempData["SkillMessage"] = "Yetenek başarıyla eklendi";
				TempData["SkillType"] = "success";
			}
			else
			{
				TempData["ServiceMessage"] = "Yetenek düzenlenirken bir hata ile karşılaşıldı";
				TempData["ServiceType"] = "error";
			}

			return RedirectToAction("Index");
		}
	}
}
