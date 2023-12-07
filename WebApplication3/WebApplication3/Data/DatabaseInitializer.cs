using WebApplication3.Data;
using WebApplication3.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace WebApplication3.Data
{
    public class DatabaseInitializer : DropCreateDatabaseIfModelChanges<EmployeeDbContext>
    {
    protected override void Seed(EmployeeDbContext context)
    {
     //Add default data to DeptMaster table
     //Example:
    context.DeptMasters.Add(new DeptMaster { DeptCode = 1, DeptName = "IT" });
    context.DeptMasters.Add(new DeptMaster { DeptCode = 2, DeptName = "HR" });

    base.Seed(context);
     }
    //public static void DatabaseInitializer(EmployeeDbContext context)
    //{
        //context.Database.DeptCreated();

        //if (context.EmpProfiles.Any())
       // {
           // return;
        //}

        //var EmpProfile = new EmpProfile[]
       // {
               // new EmpProfile()
          //  {
              //  EmpName ="Raji",
               // EmpCode="1";


    }
}
            