// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Mvc;
// using WebApi.Models;
 
// namespace WebApi.Controllers
// {
//    // [ApiController]
//    // [Route("api/[controller]")]
//     public class EmployeedbController : ControllerBase
//     {
//         public ApplicationDbContext db;
//         public EmployeedbController(ApplicationDbContext option)
//         {
//             db = option;
//         }
 
//         [HttpGet]
//         public IActionResult Get()//fetching of data by other
//         {
//             return Ok(db.Employees);//200 code
//         }
 
//         [HttpPost]
 
//         public IActionResult Post(Employee e)//inseryting of data
//         {
//             db.Add(e);
//             db.SaveChanges();
//             return Ok();
//         }
 
       
//     }
// }