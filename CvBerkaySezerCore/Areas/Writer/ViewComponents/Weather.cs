﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Globalization;
using System.Linq;
using System.Xml.Linq;

namespace CvBerkaySezerCore.Areas.Writer.ViewComponents
{
    public class Weather : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            string apiKey = "f326293d48afd27df13cced30b40febe";
            string connection = $"https://api.openweathermap.org/data/2.5/weather?q=ankara&appid={apiKey}&mode=xml&lang=tr&units=metric";
            XDocument document = XDocument.Load(connection);
            string temp = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            double dTemp = Convert.ToDouble(temp.Replace(".",","));
            ViewBag.Weather = Convert.ToInt32(dTemp);
            return View();
        }
    }
}
