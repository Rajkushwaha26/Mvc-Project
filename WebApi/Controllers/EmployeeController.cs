// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Mvc;
// using WebApi.Models;
 
// namespace WebApi.Controllers
// {
//     [ApiController]
//     [Route("api/[controller]")]
//     public class EmployeeDbController : ControllerBase
//     {
//         public ApplicationDbContext db;
//         public EmployeeDbController(EmployeeDbContext option)
//         {
//             db = option;
//         }
 
//         [HttpGet]
//         public IActionResult Get()
//         {
//             return Ok(db.Employees);
//         }
 
//         [HttpPost]
 
//         public IActionResult Post(Employee e)
//         {
//             db.Add(e);
//             db.SaveChanges();
//             return Ok();
//         }
 
       
//     }
// }