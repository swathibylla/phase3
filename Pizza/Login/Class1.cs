using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;

namespace Login
{
    public class LoginService
    {
        public bool AuthenticateUser(string userType,string username, string password)
        {
            if(userType == "User" && username == "user123" && password == "password123")
            {
                return true;
            }
            else if(userType=="Admin" && username == "admin" && password == "adminpass")
            {
                return true;
            }
            return false;
        }
    }
}
