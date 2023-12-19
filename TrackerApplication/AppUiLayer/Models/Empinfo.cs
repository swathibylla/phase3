using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppUiLayer.Models
{
    public class Empinfo
    {
        private string _emailid;

        public string EmailId
        {
            get
            {
                return _emailid;
            }
            set
            {
                _emailid = value;
            }
        }
        public string _Name;
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
            }
        }

        private DateTime _dateofjoining;

        public DateTime DateOfJoining
        {
            get
            {
                return _dateofjoining;
            }
            set
            {
                _dateofjoining = value;
            }
        }

        private int _passcode;

        public int PassCode
        {
            get
            {
                return _passcode;
            }
            set
            {
                _passcode = value;
            }

        }
    }
}