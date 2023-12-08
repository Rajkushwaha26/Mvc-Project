using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dotnetapp.Models;

namespace dotnetapp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PaymentController : ControllerBase
    {
        private readonly ApplicationDbContext db;

        public PaymentController(ApplicationDbContext context){
            this.db=context;
        }
        
    
        [HttpGet]
        [Route("GetPayments")]
        public IActionResult GetPayments(){
            var menulist=db.Payments;
            return Ok(menulist);
        }

        [HttpPost]
        [Route("PostPayments")]
        public IActionResult PostPayments(Payment b){
            db.Payments.Add(b);
            db.SaveChanges();
            return Ok();
        }
        
    }
}