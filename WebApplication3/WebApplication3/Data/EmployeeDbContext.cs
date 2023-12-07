using WebApplication3.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace WebApplication3.Data
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext() : base("name=EmployeeDbContext") { }
        public DbSet<DeptMaster> DeptMasters { get; set; }
        public DbSet<EmpProfile> EmpProfiles { get; set; }
    }
}