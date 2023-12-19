using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppUiLayer.Models
{
    public class Bloginfo
    {
        private int _BlogId;

        public int BlogId
        {
            get { return _BlogId; }
            set { _BlogId = value; }
        }

        private string _title;

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        private string _subject;

        public string Subject
        {
            get { return _subject; }
            set { _subject = value; }
        }

        private DateTime _dateofcreation;

        public DateTime DateOfCreation
        {
            get { return _dateofcreation; }
            set
            {
                _dateofcreation = value;
            }
        }

        private string _blogurl;

        public string BlogUrl
        {
            get { return _blogurl; }
            set
            {
                _blogurl = value;
            }
        }

        private string _empemailid;

        public string EmpemailId
        {
            get { return _empemailid; }
            set
            {
                _empemailid = value;
            }
        }
    }
}