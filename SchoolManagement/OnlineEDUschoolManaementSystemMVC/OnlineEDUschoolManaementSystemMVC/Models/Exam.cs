//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineEDUschoolManaementSystemMVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Exam
    {
        public int ExamId { get; set; }
        public Nullable<int> classId { get; set; }
        public Nullable<int> subjectId { get; set; }
        public string RollNo { get; set; }
        public Nullable<int> TotalMarks { get; set; }
        public Nullable<int> OutofMarks { get; set; }
    
        public virtual Class Class { get; set; }
        public virtual Subject Subject { get; set; }
    }
}
