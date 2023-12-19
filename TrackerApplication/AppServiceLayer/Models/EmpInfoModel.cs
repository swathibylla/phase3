using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppServiceLayer.Models
{
    public class EmpInfoModel
    {
        [Required()]
        public string EmailId { get; set; }

        [MaxLength(30, ErrorMessage = "Not allowed above 30 chars")]
        [MinLength(3, ErrorMessage = "Not allowed below 3 chars")]
        public string Name { get; set; }

        public DateTime DateOfJoining { get; set; }

        public int PassCode { get; set; }


    }
}