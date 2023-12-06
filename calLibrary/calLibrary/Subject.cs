using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calLibrary
{
    public  class Subject:ISubject
    {
        public string SubjectName { get; set; }
        public int Hours { get; set; }
        public Subject(string subjectName,int hours)
        {
            SubjectName = subjectName;
            Hours = hours;
        }
        public string GetSubjectName()
        {
            return SubjectName;
        }
    }
}
