﻿using Microsoft.AspNetCore.Mvc;
using Section2_3.Models;
using System.Diagnostics;
using System.Text;

namespace Section2_3.Controllers
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

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Info(String t)
        {
            ViewData["Message"] = "You have requested info for " + t;

            return View();
        }
        [HttpPost]
        public IActionResult StudentDetails(String t)
        {
            StringBuilder sb = new StringBuilder("<b>Student details entered:</b><br>");
            sb.Append("Name: " + Request.Form["name"].ToString() + "<Br>");
            sb.Append("Address: " + Request.Form["address"].ToString() + "<Br>");
            sb.Append("Subject: " + Request.Form["subject"].ToString() + "<Br>");

            ViewData["message"] = sb.ToString();
            return View();
        }

    


    
    }
}