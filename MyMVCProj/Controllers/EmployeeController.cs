// using System;
// using System.Collections.Generic;
// using System.Diagnostics;
// using System.Linq;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Mvc;
// using Microsoft.Extensions.Logging;
// using Microsoft.AspNetCore.Mvc.Rendering;
// using MyMVCProj.Data;
// using Microsoft.EntityFrameworkCore.SqlServer;

// namespace MyMVCProj.Controllers
// {
    
//     //[Route("[controller]")]
//     public class EmployeeController : Controllers
//     {
//         CodeFirstDbContext db =new CodeFirstDbContext();

//         public IActionResult Index()

//         {
//             var empList = db.Employees.Include("Department");

//             ViewBag.count = db.Employee.Count();
//             ViewBag.maxsalary=db.Employees.Max(e=>e.Salary);
//             return View(empList);
//         }

//         public IActionResult Create()

//         {
//             var depList = db.Departments;
//             SelectList s1 = new SelectList(depList,"DepartmentId", "DepartmentName");
//             ViewBag.deptData=s1;
//             return View();
//         }

//         [HttpPost]
//         public IActionResult Create(Employee obj)

//         {
//             {
//                 db.Employee.Add(obj);
//                 db.SaveChange();
//             }
//             return RedirectToAction("Index");
//         }

//         public IActionResult Delete(int id)
//         {
//             var emp = db.Employee.FirstOrDefault(e=>e.EmployeeId==id);
//             if(emp!=null)
        
//             {
//                 db.Employee.Remove(emp);
//                 db.SaveChanges();
//             }
//             return RedirectToAction("index");
//         }

//         public IActionResult Edit(int id)
//         {
//             var depList=db.Departments;
//             var depList = db.Departments;
//             SelectList s1 = new SelectList(depList,"DepartmentId", "DepartmentName");
//             ViewBag.deptData=s1;

//             var emp = db.Employee.FirstOrDefault(e=>e.EmployeeId==id);
//             if(emp!=null)
//                 return View(emp);
//             else
//                 return RedirectToAction("index");
//         }


//         [HttpPost]
//         public IActionResult Edit(Employee newempObj){
//             db.Update(newempObj);
//             db.SaveChanges();
//             return RedirectToAction("index");
//         }

//         public IActionResult Privacy()
//         {
//             return View();
//         }

//             [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
//             public IActionResult Error()
//             {
//                 return View("Error!");
//             }
//         }
// }

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MvcCodeFirstApp.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyMVCProj.Data;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace MvcCodeFirstApp.Controllers
{
    //[Route("[controller]")]
    public class EmployeeController : Controller
    {
        CodeFirstDbContext db = new CodeFirstDbContext();
    

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