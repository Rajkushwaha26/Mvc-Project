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
    public class AddressCartItemController : ControllerBase
    {
        private readonly ApplicationDbContext db;

        public AddressCartItemController(ApplicationDbContext context){
            this.db=context;
        }
        [HttpGet]
        [Route("GetAddressDetails")]
        public IActionResult GetAddressDetails(){
            var adlist=db.AddressDetails;
            return Ok(adlist);
        }

        [HttpPost]
        [Route("PostAddressDetails")]
        public IActionResult PostAddressDetails(AddressDetail b){
            db.AddressDetails.Add(b);
            db.SaveChanges();
            return Ok();
        }
        //Cart
        [HttpGet]
        [Route("GetCartItems")]
        public IActionResult GetCartItems(){
            var adlist=db.CartItems;
            return Ok(adlist);
        }

        [HttpPost]
        [Route("PostCartItem")]
        public IActionResult PostCartItem(CartItem b){
            db.CartItems.Add(b);
            db.SaveChanges();
            return Ok();
        }
        
    }
}