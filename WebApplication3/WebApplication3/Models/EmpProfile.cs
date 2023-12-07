using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{

    public class EmpProfile
    {
        [Key]
        public int EmpCode { get; set; }

        [Required(ErrorMessage = "Employee Name is required.")]
        [StringLength(100, ErrorMessage = "Employee Name cannot exceed 100 characters.")]
        public string EmpName { get; set; }

        [Required(ErrorMessage = "Date of Birth is required.")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid Email Address.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Department Code is required.")]
        public int DeptCode { get; set; }

        //    [ForeignKey("DeptCode")] // Specify the actual property name here
        //     public virtual DeptMaster DeptMaster { get; set; }
        ////public virtual DeptMaster DeptMaster{   get; set;}
    }
    // Navigation propert
}