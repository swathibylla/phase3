using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SeedMethod : DropCreateDatabaseIfModelChanges<MyContext>
    {
        protected override void Seed(MyContext context)
        {
            List<AdminInfo> AdminInfolist = new List<AdminInfo>();
            AdminInfolist.Add(
                new AdminInfo()
                {
                    EmailId = "admin@gmail.com",
                    Password = "admin123"
                }
                );
            context.AdminInfoTable.AddRange(AdminInfolist);

            List<BlogInfo> BlogInfolist = new List<BlogInfo>();
            BlogInfolist.Add(
                new BlogInfo()
                {
                    BlogId = 1,
                    Title = "TodayNews",
                    Subject = "Sports",
                    DateOfCreation = new DateTime(2000, 09, 09),
                    BlogUrl = "https://timesofindia.indiatimes.com/sports",
                    EmpEmailId = "Buttler@gmail.com"


                }

                );
            context.BlogInfoTable.AddRange(BlogInfolist);

            List<EmpInfo> EmpInfolist = new List<EmpInfo>();
            EmpInfolist.Add(
                new EmpInfo()
                {
                    EmailId = "Buttler@gmail.com",
                    Name = "Buttler",
                    DateOfJoining = new DateTime(2000, 09, 09),
                    PassCode = 123
                }
                );
            context.EmpInfoTable.AddRange(EmpInfolist);
            context.SaveChanges();
            base.Seed(context);
        }
    }
}
