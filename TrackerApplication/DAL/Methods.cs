using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Methods
    {
        MyContext Context = null;
        public Methods()
        {
            Context = new MyContext();
        }

        public List<AdminInfo> ShowallAdminInfo()
        {
            return Context.AdminInfoTable.ToList();

        }

        public List<EmpInfo> ShowallEmployeeInfo()
        {
            return Context.EmpInfoTable.ToList();

        }

        public List<BlogInfo> ShowallBlogInfo()
        {
            return Context.BlogInfoTable.ToList();

        }


        public void InsertEmpInfo(EmpInfo emp)
        {


            Context.EmpInfoTable.Add(emp);
            Context.SaveChanges();

        }

        public void InsertBlogInfo(BlogInfo blog)
        {


            Context.BlogInfoTable.Add(blog);
            Context.SaveChanges();

        }


        public void UpdateEmpInfo(string id, EmpInfo emp)
        {
            var a = Context.EmpInfoTable.ToList().Find(b => b.EmailId == id);
            Context.EmpInfoTable.Remove(a);
            Context.EmpInfoTable.Add(emp);
            Context.SaveChanges();

        }

        public void UpdateBlogInfo(int id, BlogInfo blog)
        {
            var a = Context.BlogInfoTable.ToList().Find(b => b.BlogId == id);
            Context.BlogInfoTable.Remove(a);
            Context.BlogInfoTable.Add(blog);
            Context.SaveChanges();

        }



        public void DeleteEmpInfo(string id)
        {
            var e = Context.EmpInfoTable.ToList().Find(d => d.EmailId == id);
            Context.EmpInfoTable.Remove(e);
            Context.SaveChanges();
        }

        public void DeleteBlogInfo(int id)
        {
            var e = Context.BlogInfoTable.ToList().Find(d => d.BlogId == id); ;
            Context.BlogInfoTable.Remove(e);
            Context.SaveChanges();
        }



        public EmpInfo findEmpInfobyid(string id)
        {

            var u = Context.EmpInfoTable.ToList().Find(f => f.EmailId == id);
            return u;
        }

        public BlogInfo findBlogInfobyid(int id)
        {

            var a = Context.BlogInfoTable.ToList().Find(f => f.BlogId == id);
            return a;
        }

    }
}
