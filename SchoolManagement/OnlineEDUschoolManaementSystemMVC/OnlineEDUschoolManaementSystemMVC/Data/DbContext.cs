using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace OnlineEDUschoolManaementSystemMVC.Data
{
    public class SchoolSystemEntities: DbContext
    {
        public SchoolSystemEntities(): base("name=SchoolSystemEntities")
        {

        }
        public DbSet<SchoolSystemEntities> Student
        { get; set; }
    }
}