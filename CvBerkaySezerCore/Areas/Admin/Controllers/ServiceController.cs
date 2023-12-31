﻿using BusinessLayer.Concrete;
using CvBerkaySezerCore.ViewModels;
using CvBerkaySezerCore.Areas.Admin.ViewComponents;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Authorization;
using System.Data;

namespace CvBerkaySezerCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class ServiceController : Controller
    {
        ServiceImageManager serviceManager = new ServiceImageManager(new EfServiceImageDal());
        private readonly string header = "Hizmetler";

        public IActionResult Index()
        {
            ViewBag.Header = header;

            var services = serviceManager.TGetAll();
            return View(services);
        }

        [HttpPost]
        public IActionResult Edit(ServiceImage s)
        {
            ViewBag.Header = header;
            var service = serviceManager.TGetById(s.Id);

            if (ModelState.IsValid)
            {
                //if (Request.Files.Count > 0)
                //{
                //    string image = SaveImage.SaveContentImage(Request, Server, s.Title.Replace(" ", ""));
                //    if (!string.IsNullOrEmpty(image)) service.ImageUrl = image;
                //}

                service.IsDeleted = s.IsDeleted;
                service.Title = s.Title.Trim();

                serviceManager.TUpdate(service);

                TempData["ServiceMessage"] = "Hizmet başarıyla düzenlendi";
                TempData["ServiceType"] = "success";
            }
            else
            {
                TempData["ServiceMessage"] = "Hizmet düzenlenirken bir hata ile karşılaşıldı";
                TempData["ServiceType"] = "error";
            }


            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Add(AddServiceViewModel s)
        {
            ViewBag.Header = header;
            if (ModelState.IsValid)
            {
                //if (Request.Files.Count > 0)
                //{
                //    string image = SaveImage.SaveContentImage(Request, Server, s.AddTitle.Replace(" ", ""));
                //    if (!string.IsNullOrEmpty(image)) s.AddImageUrl = image;
                //}

                ServiceImage service = new ServiceImage
                {
                    Title = s.AddTitle.Trim(),
                    ImageUrl = "template/images/services/web-design.svg"
                };

                serviceManager.TAdd(service);

                TempData["ServiceMessage"] = "Hizmet başarıyla eklendi";
                TempData["ServiceType"] = "success";
            }
            else
            {
                TempData["ServiceMessage"] = "Hizmet düzenlenirken bir hata ile karşılaşıldı";
                TempData["ServiceType"] = "error";
            }

            return RedirectToAction("Index");
        }
    }
}
