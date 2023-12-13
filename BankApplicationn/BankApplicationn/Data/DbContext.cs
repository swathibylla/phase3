using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BankApplicationn.Models
{
    public class BankDbContext:DbContext
    {
        public DbSet<UserInfo> UserInfo { get; set; }

        public BankDbContext(): base("name = BankDbContext")
        {

        }
    }
}