using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using Section2._3.Models;

namespace Section2_3.Controllers
{
    public class HomeController : Controller
    {
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

        public ContentResult StudentAsString()
        {
            return Content(" student is Walter Smith .");
        }

        public ViewResult StudentView()
        {
            ViewData["message"] = "The name of the student is <b>Kavya</b> and he is  Grade 9 .";
            return View();
        }

        public RedirectResult StudentAsRedirectResult()
        {
            return new RedirectResult("https://www.bing.com/search?q=walter+smith");
        }

        public RedirectToRouteResult StudentAsRedirectToRouteResult()
        {
            return new RedirectToRouteResult(new { Controller = "Home", action = "StudentView" });
        }

        public FileResult StudentAsFileResult()
        {
            byte[] fileBytes = System.IO.File.ReadAllBytes(@"./wwwroot/StudentData/StudentD.txt");
            string fileName = "StudentD.txt";
            return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);
        }
        public JsonResult StudentAsJSONResult()
        {
            String data = System.IO.File.ReadAllText(@".\wwwroot\Studentdata.json");
            JObject json = JObject.Parse(data);
            return Json(json);
        }

        public ViewResult StudentList()
        {
            return View();
        }
    }
}

