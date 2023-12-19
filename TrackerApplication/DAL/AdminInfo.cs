using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
    public class AdminInfo
    {
        [Key]
        public string EmailId { get; set; }

        [MaxLength(30, ErrorMessage = "Not allowed above 30 chars")]
        [MinLength(3, ErrorMessage = "Not allowed below 3 chars")]
        public string Password { get; set; }
    }
    public class MyContext : DbContext
    {
        public MyContext() : base("MyContext")
        {
            Database.SetInitializer(new SeedMethod());
        }

        public virtual DbSet<AdminInfo> AdminInfoTable { get; set; }

        public virtual DbSet<BlogInfo> BlogInfoTable { get; set; }

        public virtual DbSet<EmpInfo> EmpInfoTable { get; set; }

    }
}
