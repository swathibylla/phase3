using BankApplicationn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace BankApplicationn.Controllers
{
    public class LoginController : Controller
    {
        BankDbContext db = new BankDbContext();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(UserInfo userInfo)
        {
            if (ModelState.IsValid)
            {
                if (db.UserInfo.Any(x => x.username == userInfo.username))
                {
                    ViewBag.Message = "username already exist";
                }
                else
                {
                    db.UserInfo.Add(userInfo);
                    db.SaveChanges();
                    Response.Write("<script>alert('Login Successfull')</script>");
                }
            }
            return View();
        }
    }
}

