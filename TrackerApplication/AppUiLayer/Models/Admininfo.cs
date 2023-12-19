using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppUiLayer.Models
{
    public class Admininfo
    {
        private string _emailid;

        public string EmailId
        {
            get { return _emailid; }
            set { _emailid = value; }
        }

        private string _password;

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

    }
}