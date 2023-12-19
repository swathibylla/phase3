using AppUiLayer.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;

namespace AppUiLayer.Controllers
{
    public class EmpInfoController : Controller
    {
        public ActionResult EmpInfo()
        {
            List<Empinfo> l = new List<Empinfo>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44345/api/");
                var responseTask = client.GetAsync("EmpInfo");
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readData = result.Content.ReadAsAsync<Empinfo[]>();
                    readData.Wait();
                    var emp = readData.Result;
                    foreach (var item in emp)
                    {
                        l.Add(new Empinfo
                        {
                            EmailId = item.EmailId,
                            Name = item.Name,
                            DateOfJoining = item.DateOfJoining,
                            PassCode = item.PassCode

                        });
                    }
                }
            }
            return View(l);

        }

        public ActionResult AddEmpInfo()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddEmpInfo(Empinfo emp)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44345/api/EmpInfo");
                var b = new Empinfo { EmailId = emp.EmailId, Name = emp.Name, DateOfJoining = emp.DateOfJoining, PassCode = emp.PassCode };
                var Post = client.PostAsJsonAsync<Empinfo>(client.BaseAddress, emp);
                Post.Wait();
                var result = Post.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readtask = result.Content.ReadAsAsync<Empinfo>();
                    readtask.Wait();
                    var dataInserted = readtask.Result;
                }
            }
            return RedirectToAction("EmpInfo");
        }

        public ActionResult AdminLogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AdminLogin(FormCollection collection)
        {
            List<Admininfo> l = new List<Admininfo>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44345/api/");
                var responseTask = client.GetAsync("AdminInfo");
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readData = result.Content.ReadAsAsync<Admininfo[]>();
                    readData.Wait();
                    var admin = readData.Result;
                    foreach (var item in admin)
                    {
                        l.Add(new Admininfo { EmailId = item.EmailId, Password = item.Password });

                    }
                }
            }
            var ans = l.Find(s => s.EmailId == Request["EmailId"]);
            if (ans != null)
            {
                if (ans.Password == Request["Password"])
                {
                    return RedirectToAction("EmpInfo");
                }
                else
                {
                    ViewBag.msg = "IncorrectPassword";
                }

            }
            else
            {
                ViewBag.msg = "EmailId Not Found";
            }
            return View();
        }

    }
}
