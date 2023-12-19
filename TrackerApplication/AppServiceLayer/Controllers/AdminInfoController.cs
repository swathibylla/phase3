using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using AppServiceLayer.Models;
using System.Web.Mvc;
using DAL;

namespace AppServiceLayer.Controllers
{
    public class AdminInfoController : ApiController
    {
        Methods a1 = null;
        public AdminInfoController()
        {
            a1 = new Methods();
        }



        public List<AdminInfo> Get()
        {
            List<AdminInfo> l = new List<AdminInfo>();
            var b = a1.ShowallAdminInfo();
            foreach (var item in b)
            {
                l.Add(

                    new AdminInfo()
                    {
                        EmailId = item.EmailId,
                        Password = item.Password
                    }
                );
            }
            return l;


        }



    }
}