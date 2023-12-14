using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.Entity;
using OnlineEDUschoolManaementSystemMVC.Models;

namespace OnlineEDUschoolManaementSystemMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }

        public ActionResult Courses()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }





        public ActionResult Registration()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Registration(Student r)
        {
            using (SchoolsystemEntities db = new SchoolsystemEntities())
            {
                if (ModelState.IsValid)
                {
                    db.Students.Add(r);
                    db.SaveChanges();
                    //  ViewBag.message("Register Sucess");
                    ModelState.Clear();
                }
            }
            return View(r);
        }
        [HttpPost]
        public ActionResult Login(Student r1)
        {
            using (SchoolsystemEntities db = new SchoolsystemEntities())
            {
                if (ModelState.IsValid)
                {
                    var log = db.Students.Where(a => a.Name.Equals(r1.Name) && a.studentId.Equals(r1.studentId)).FirstOrDefault();
                    if (log != null)
                    {
                        return RedirectToAction("Contact");
                    }
                    db.SaveChanges();
                    // ViewBag.message("Login Sucess");
                    ModelState.Clear();
                }
            }
            return View(r1);
        }

    }
}