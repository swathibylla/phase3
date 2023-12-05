﻿using Microsoft.AspNetCore.Mvc;
using Section2_18.Models;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Section2_18.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult StudentEditView()
        {
            return View();
        }

        [HttpPost]
        public ContentResult StudentEditView(StudentModel model)
        {
            String result = model.Name + "," + model.Address + "," + model.WhichClass + "," + model.TotalMarks.ToString();
            return Content("Form was submitted:\n" + result);
        }

       
    }
}