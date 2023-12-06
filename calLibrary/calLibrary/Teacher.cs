using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calLibrary
{
    public class Teacher:ITeacher
    {
    public string Name { get; set; }
    public  string Subject { get; set; }

        public Teacher(string name,string subject)
        {
            Name = name;
            Subject = subject;
        }
        public  virtual string GetName()
        {
            return Name;
        }
        
    }
    
}
