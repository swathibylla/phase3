﻿using HtmlForms.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HtmlForms.Controllers
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
        public IActionResult FormGet()
        {
            ViewData["name"] = Request.Query["name"].ToString();
            ViewData["email"] = Request.Query["email"].ToString();
            ViewData["class"] = Request.Query["class"].ToString();
            ViewData["address"] = Request.Query["address"].ToString();
            return View();
        }

        [HttpPost]
        public IActionResult FormPost(string name, string address, string email, string whichclass)
        {
            ViewData["name"] = name;
            ViewData["email"] = email;
            ViewData["class"] = whichclass;
            ViewData["address"] = address;
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
    }
}


