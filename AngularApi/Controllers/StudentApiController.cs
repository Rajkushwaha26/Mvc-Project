using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AngularApi.Models;

namespace AngularApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentApiController : ControllerBase
    {
        private readonly AppDbContext db;

        public StudentApiController(AppDbContext context ){
            this.db=context;
        }

         [HttpGet]
        public IActionResult Get()//fetching of data by other
        {
            return Ok(db.Students);//200 code
        }
 
        [HttpPost]
 
        public IActionResult Post(Student e)//inseryting of data
        {
            db.Add(e);
            db.SaveChanges();
            return Ok();
        }


        
    }
}