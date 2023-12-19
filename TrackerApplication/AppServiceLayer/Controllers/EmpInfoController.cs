using AppServiceLayer.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace AppServiceLayer.Controllers
{
    public class EmpInfoController : ApiController
    {
        Methods a = null;
        public EmpInfoController()
        {
            a = new Methods();
        }



        public List<EmpInfo> Get()
        {
            List<EmpInfo> l = new List<EmpInfo>();
            var b = a.ShowallEmployeeInfo();
            foreach (var item in b)
            {
                l.Add(

                    new EmpInfo()
                    {
                        EmailId = item.EmailId,
                        Name = item.Name,
                        DateOfJoining = item.DateOfJoining,
                        PassCode = item.PassCode,

                    }
                );
            }
            return l;


        }


        public EmpInfo Get(string id)
        {
            EmpInfoModel e = new EmpInfoModel();
            EmpInfo emp = a.findEmpInfobyid(id);
            e.EmailId = emp.EmailId;
            e.Name = emp.Name;
            e.DateOfJoining = emp.DateOfJoining;
            e.PassCode = emp.PassCode;
            return emp;
        }



        public void Post([FromBody] EmpInfoModel empd)
        {
            EmpInfo e = new EmpInfo();

            e.EmailId = empd.EmailId;
            e.Name = empd.Name;
            e.DateOfJoining = empd.DateOfJoining;
            e.PassCode = empd.PassCode;

            a.InsertEmpInfo(e);


        }


        public void Put(string id, [FromBody] EmpInfoModel emp)
        {
            EmpInfo e = new EmpInfo();

            e.EmailId = emp.EmailId;
            e.Name = emp.Name;
            e.DateOfJoining = emp.DateOfJoining;
            e.PassCode = emp.PassCode;

            a.UpdateEmpInfo(id, e);
        }


        public void Delete(string id)
        {
            a.DeleteEmpInfo(id);
        }
    }
}