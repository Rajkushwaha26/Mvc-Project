using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EMSP.Controllers
{
    //[Route("[controller]")]
    public class DepartmentController : ControllerBase
    {
        public DepartmentController(IDecrementOperators _repo){
            this.repo=_repo;
        }
        [HttpPost]
        public IActionResult GetDept(){
            var data = repo.GetDepartments();
            return Ok(data);
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