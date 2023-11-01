using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CDStudent.Models;
namespace CDStudent.Controllers
{
    //[Route("[controller]")]
    public class StudentesController : Controller
    {
        StudentDbContext db = new StudentDbContext();

        public IActionResult Index()
        {
            var stdata = db.Students;

            return View(stdata);
        }
        [HttpGet]
        public IActionResult Create(){
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student b){
            db.Students.Add(b);
            db.SaveChanges();

;            return View();

        }
        


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}