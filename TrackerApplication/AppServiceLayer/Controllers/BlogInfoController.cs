using AppServiceLayer.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace AppServiceLayer.Controllers
{
    public class BlogInfoController : ApiController
    {
        Methods a1 = null;
        public BlogInfoController()
        {
            a1 = new Methods();
        }



        public List<BlogInfo> Get()
        {
            List<BlogInfo> l = new List<BlogInfo>();
            var b = a1.ShowallBlogInfo();
            foreach (var item in b)
            {
                l.Add(

                    new BlogInfo()
                    {
                        BlogId = item.BlogId,
                        Title = item.Title,
                        Subject = item.Subject,
                        DateOfCreation = item.DateOfCreation,
                        BlogUrl = item.BlogUrl,
                        EmpEmailId = item.EmpEmailId
                    }
                );
            }
            return l;


        }



        public BlogInfo Get(int id)
        {
            BlogInfoModel b = new BlogInfoModel();
            BlogInfo blog = a1.findBlogInfobyid(id);
            b.BlogId = Convert.ToInt32(blog.BlogId);
            b.Title = blog.Title.ToString();
            b.Subject = blog.Subject.ToString();
            b.DateOfCreation = Convert.ToDateTime(blog.DateOfCreation);
            b.EmpEmailId = blog.EmpEmailId.ToString();

            return blog;
        }



        public void Post([FromBody] BlogInfoModel blog)
        {
            BlogInfo b = new BlogInfo();

            b.BlogId = blog.BlogId;
            b.Title = blog.Title;
            b.Subject = blog.Subject;
            b.DateOfCreation = blog.DateOfCreation;
            b.BlogUrl = blog.BlogUrl;
            b.EmpEmailId = blog.EmpEmailId;

            a1.InsertBlogInfo(b);


        }


        public void Put(int id, [FromBody] BlogInfoModel blog)
        {
            BlogInfo b = new  BlogInfo();
            b.BlogId = blog.BlogId;
            b.Title = blog.Title;
            b.Subject = blog.Subject;
            b.DateOfCreation = blog.DateOfCreation;
            b.EmpEmailId = blog.EmpEmailId;

            a1.UpdateBlogInfo(id, b);
        }


        public void Delete(int id)
        {
            a1.DeleteBlogInfo(id);
        }
    }
}