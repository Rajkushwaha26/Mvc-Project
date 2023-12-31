using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EMSP.Models;


namespace EMSP.Controllers
{
    //[Route("[controller]")]
    public class DepartmentController : ControllerBase
    {
        IDept repo;
        public DepartmentController(IDept _repo)
        {
            this.repo=_repo;
        }

        [HttpPost]
        [Route("ListDept")]
        public IActionResult GetDept()
        {
            var data = repo.GetDepartments();
            return Ok(data);
        }

        [HttpPost]
        [Route("Create")]
        public IActionResult PostDept(Department department)
        {
            if(ModelState.IsValid)
            {
                repo.AddDept(department);
                return Created("Record Added",department);
            }
            return BadRequest();
        }

        [HttpGet]
        [Route("ListDept/(id)")]
        public IActionResult GetDept(int id)
        {
            var data=repo.FindDept(id);
            return Ok(data);
        }

         [HttpPut]
        [Route("ListDept/(id)")]
        public IActionResult PutDept(int id, Department department)
        {
            repo.EditDept(department);
            return Ok();
        }
        
    }
}
