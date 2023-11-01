using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Realme.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Realme.Controllers
{
    //[Route("[controller]")]
    public class EmployeeController : Controller
    {
        // private readonly ILogger<EmployeeController> _logger;

        // public EmployeeController(ILogger<EmployeeController> logger)
        // {
        //     _logger = logger;
        // }

        RealmeDBContext db = new RealmeDBContext();

        public IActionResult Index()
        {
            var empList = db.Employees.Include("Department");
            
            ViewBag.Count = db.Employees.Count();
            ViewBag.maxSalary = db.Employees.Max(e => e.Salary);
            return View(empList);
            
        }

         public IActionResult Create()
        {
            var deptList = db.Departments;
            SelectList sl = new SelectList(deptList, "DepartmentId", "DepartmentName");
            ViewBag.deptData = sl;
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee obj)
        {
            db.Employees.Add(obj);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var emp = db.Employees.FirstOrDefault(e => e.EmployeeId == id);
            if(emp!=null)
            {
                db.Employees.Remove(emp);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var deptList = db.Departments;
            SelectList sl = new SelectList(deptList, "DepartmentId", "DepartmentName");
            ViewBag.deptData = sl;

            var emp = db.Employees.FirstOrDefault(e => e.EmployeeId == id);
            if(emp!=null)
            {
                return View(emp);
            }
            else
            {
                return RedirectToAction("index");
            }
        }
        [HttpPost]
        public IActionResult Edit(Employee newempObj)
        {
            db.Update(newempObj);
            db.SaveChanges();
            return RedirectToAction("index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}
