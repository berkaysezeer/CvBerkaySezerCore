﻿using Microsoft.AspNetCore.Mvc;

namespace CvBerkaySezerCore.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}