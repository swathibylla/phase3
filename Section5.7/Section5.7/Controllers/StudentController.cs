﻿using Section5._7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Net;
using System.Net.Http;

namespace Section5._7.Controllers
{
    public class StudentController : ApiController
    {
        public IHttpActionResult GetAllStudents()
        {
            IList<StudentViewModel> students = null;

            using (var ctx = new RainbowSchoolEntities1())
            {
                students = ctx.Students
                            .Select(s => new StudentViewModel()
                            {
                                Id = s.ID,
                                Name = s.Name,
                                Email = s.Email,
                                Class = s.Class,
                                Address = s.Address
                            }).ToList<StudentViewModel>();
            }

            if (students.Count == 0)
            {
                return NotFound();
            }

            return Ok(students);
        }

        public IHttpActionResult PostNewStudent(StudentViewModel student)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid data.");

            using (var ctx = new RainbowSchoolEntities1())
            {
                ctx.Students.Add(new Student()
                {
                    Name = student.Name,
                    Email = student.Email,
                    Address = student.Address,
                    Class = student.Class
                });

                ctx.SaveChanges();
            }

            return Ok();
        }

       
        public IHttpActionResult Put(StudentViewModel student)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");

            using (var ctx = new RainbowSchoolEntities1())
            {
                var existingStudent = ctx.Students.Where(s => s.ID == student.Id)
                                                        .FirstOrDefault<Student>();

                if (existingStudent != null)
                {
                    existingStudent.Name = student.Name;
                    existingStudent.Address = student.Address;
                    existingStudent.Email = student.Email;
                    existingStudent.Class = student.Class;

                    ctx.SaveChanges();
                }
                else
                {
                    return NotFound();
                }
            }

            return Ok();
        }

        
        public IHttpActionResult Delete(int id)
        {
            if (id <= 0)
                return BadRequest("Not a valid student id");

            using (var ctx = new RainbowSchoolEntities1())
            {
                var student = ctx.Students
                    .Where(s => s.ID == id)
                    .FirstOrDefault();

                ctx.Entry(student).State = System.Data.Entity.EntityState.Deleted;
                ctx.SaveChanges();
            }

            return Ok();
        }

    }
}