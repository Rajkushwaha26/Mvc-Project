using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NewProj.Models;

namespace NewProj.Controllers
{
    [Route("[controller]")]
    public class StudentController : Controller
    {
        private readonly ILogger<StudentController> _logger;

        public StudentController(ILogger<StudentController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()

        {
            var Students = new List<student>{
                new student{RollNo =1, Name = "Raj", Gender="Male",Standard=10},
                new student{RollNo =1, Name = "shiv", Gender="Male",Standard=9},
                new student{RollNo =1, Name = "Ritu", Gender="Female",Standard=12}

            };
            ViewData["myStudent"] = Students;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}