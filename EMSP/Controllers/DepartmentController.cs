using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using E


namespace EMSP.Controllers
{
    //[Route("[controller]")]
    public class DepartmentController : ControllerBase
    {
        IDept repo;
        public DepartmentController(IDept _repo){
            this.repo=_repo;
        }
        [HttpPost]
        [Route("ListDept")]
        public IActionResult GetDept(){
            var data = repo.GetDepartments();
            return Ok(data);
        }

        [HttpPost]
        [Route("Create")]
        public IActionResult PostDept(DepartmentController department){
            if(ModelState.IsValid){
                repo.AddDept(department);
                return Created("Record Added");
            }
            return BadRequest();
        }
        

       

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}