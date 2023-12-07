using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;


namespace phase4Project1.Pages.Account
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public Credential credential { get; set; } = default!;
        public void OnGet()
        {
            this.credential = new Credential { UserName = " " };

        }
        public void OnPost()
        {

        }
        public class Credential
        {
            [Required]
            [Display(Name = "User name")]
            public string UserName { get; set; } = default!;

            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; } = default!;
        }
    }
}
