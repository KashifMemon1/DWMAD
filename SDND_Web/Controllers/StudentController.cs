using SDND_Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SDND_Web.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View(new Student().GetAllStudent());
        }

        public ActionResult NewStudent()
        {
            return View(new Student());
        }


        public ActionResult SaveStudent(Student std)
        {
            return View();
        }
    }

}