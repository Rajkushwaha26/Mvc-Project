using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;
 
//get post put delete - only these method names are allowed
 
namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        ///////// STATIC DATA RUNING ONLINE DATA
        private static List<Employee> empList = new List<Employee>()
        {
            new Employee{EmployeeId = 101,EmployeeName = "Karan", Salary = 60000 },
            new Employee{EmployeeId = 102,EmployeeName = "Suresh", Salary = 60000 },
            new Employee{EmployeeId = 103,EmployeeName = "Vineet", Salary = 60000 },
            new Employee{EmployeeId = 104,EmployeeName = "Rahul", Salary = 60000 },
        };

        
        [HttpGet]
        public IActionResult Get()
        {
            var emp = empList;
            return Ok(emp);
        }
        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        {
            var emp = empList.FirstOrDefault(e=>e.EmployeeId == id);
            if(emp!=null)
            {return Ok(emp);}
            else
            {return NotFound();}
        }
        [HttpPost]
        public IActionResult post(Employee e)
        {
           
            empList.Add(e);
            return Ok();
           
        }
        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {
            var emp = empList.Find(e=>e.EmployeeId == id);
            if(emp != null)
            {
                empList.Remove(emp);
                return Ok();
            }    
            else
            {
                return NotFound();
            }
        }
        //edit
        [HttpPut]
        public IActionResult Put(int id,Employee e)
        {
            var emp = empList.Find(e=>e.EmployeeId==id);
            if(emp != null)
            {
                emp.EmployeeName = e.EmployeeName;
                emp.Salary = e.Salary;
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }
    }
}