using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppServiceLayer.Models
{
    public class BlogInfoModel
    {
        [Required()]
        public int BlogId { get; set; }

        [MaxLength(30, ErrorMessage = "Not allowed above 30 chars")]
        [MinLength(3, ErrorMessage = "Not allowed below 3 chars")]
        public string Title { get; set; }

        public string Subject { get; set; }

        public DateTime DateOfCreation { get; set; }

        public string BlogUrl { get; set; }

        public string EmpEmailId { get; set; }


    }
}