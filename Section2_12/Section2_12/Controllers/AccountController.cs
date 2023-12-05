using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Section2_12.Models;
using System.Security.Claims;



namespace Section2_12.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {

            
                return View();
        }
    }
}
