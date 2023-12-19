using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using System.Net.Http.Formatting;
using AppUiLayer.Models;


namespace AppUiLayer.Controllers
{
    public class BloginfoController : Controller
    {

        MyContext a1 = new MyContext();


        public ActionResult BlogInfo()
        {
            List<Bloginfo> l = new List<Bloginfo>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44347/api/");
                var responseTask = client.GetAsync("BlogInfo");
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readData = result.Content.ReadAsAsync<Bloginfo[]>();
                    readData.Wait();
                    var emp = readData.Result;
                    foreach (var item in emp)
                    {
                        l.Add(new Bloginfo
                        {
                            BlogId = item.BlogId,
                            Title = item.Title,
                            Subject = item.Subject,
                            DateOfCreation = item.DateOfCreation,
                            BlogUrl = item.BlogUrl,
                            EmpemailId = item.EmpemailId

                        });
                    }
                }
            }
            return View(l);

        }

        public ActionResult Blogs()
        {
            List<Bloginfo> l = new List<Bloginfo>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44347/api/");
                var responseTask = client.GetAsync("BlogInfo");
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readData = result.Content.ReadAsAsync<Bloginfo[]>();
                    readData.Wait();
                    var emp = readData.Result;
                    var ans = TempData["emailid"].ToString();
                    foreach (var item in emp)
                    {
                        if (item.EmpemailId == ans)
                        {
                            l.Add(new Bloginfo
                            {
                                BlogId = item.BlogId,
                                Title = item.Title,
                                Subject = item.Subject,
                                DateOfCreation = item.DateOfCreation,
                                BlogUrl = item.BlogUrl,
                                EmpemailId = item.EmpemailId

                            });
                        }
                    }
                }
            }
            return View(l);

        }

        public ActionResult AddBlogInfo()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddBlogInfo(Bloginfo blog)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44347/api/BlogInfo");
                var b = new BlogInfo { BlogId = blog.BlogId, Title = blog.Title, Subject = blog.Subject, DateOfCreation = blog.DateOfCreation, BlogUrl = blog.BlogUrl, EmpEmailId = blog.EmpemailId };
                var Post = client.PostAsJsonAsync<Bloginfo>(client.BaseAddress, blog);
                //var Post = client.PostAsJsonAsync<Bloginfo>(client.BaseAddress, b);
                Post.Wait();
                var result = Post.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readtask = result.Content.ReadAsAsync<Bloginfo>();
                    readtask.Wait();
                    var dataInserted = readtask.Result;
                }
            }
            return RedirectToAction("BlogInfo");
        }

        public ActionResult EmpLogin()
        {

            return View();

        }

        [HttpPost]
        public ActionResult EmpLogin(FormCollection collection)
        {
            List<Empinfo> l = new List<Empinfo>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44347/api/");
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
                        l.Add(new Empinfo { EmailId = item.EmailId, PassCode = item.PassCode });

                    }
                }
            }
            var ans = l.Find(s => s.EmailId == Request["EmailId"]);
            if (ans != null)
            {
                if (ans.PassCode == Convert.ToInt32(Request["Passcode"]))
                {
                    TempData["emailid"] = ans.EmailId;
                    return RedirectToAction("Blogs");
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
        public ActionResult LogOut()
        {
            return RedirectToAction("BlogInfo");
        }




    }
}