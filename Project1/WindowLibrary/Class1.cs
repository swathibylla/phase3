using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowLibrary
{
   
    public class Teacher
    {
        public string Name { get; set; }
        public string Subjecttaught { get; set; }
        
        public class Student
        {
            public string Name { get; set; }
            public int Grade { get; set; }
           
            public class Subject
            {
                public string SubjectName { get; set; }
                public int HoursPerWeek { get; set; }
            }
            
        }
    }
}


        
