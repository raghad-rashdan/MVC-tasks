using MVC_tasks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_tasks.Views.MVC_task2
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Student()
        {
          List<Models.Student> stu = new List<Student>();
            stu.Add(new Student { ID = 27, Name = "Raghad Rashdan", Major = "CS", Faculty = "IT" });
            stu.Add(new Student { ID = 26, Name = "Raghad Alghol", Major = "CS", Faculty = "IT" });
            stu.Add(new Student { ID = 8, Name = "Eman alfokaha", Major = "SE", Faculty = "IT" });

            return View(stu);
        }
    }
}