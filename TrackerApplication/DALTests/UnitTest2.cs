using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALTests
{
    public class Validate
    {
        MyContext context = new MyContext();
        public bool AdminTest()
        {
            bool ans = false;
            var result = context.AdminInfoTable.ToList();

            if (result[0].EmailId == "admin@gmail.com" && result[0].Password == "admin123")
            {
                ans = true;
            }
            return ans;

        }
    }
}
