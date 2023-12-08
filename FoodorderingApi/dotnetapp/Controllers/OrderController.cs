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
    public class OrderController : ControllerBase
    {
        private readonly ApplicationDbContext db;

        public OrderController(ApplicationDbContext context){
            this.db=context;
        }

        [HttpGet]
        [Route("GetOrderDetail")]
        public IActionResult GetOrderDetail(){
            var orderlist=db.OrderDetails;
            return Ok(orderlist);
        }
    }
}