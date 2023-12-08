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
//Menu
        [HttpGet]
        [Route("GetMenus")]
        public IActionResult GetMenus(){
            var menulist=db.Menus;
            return Ok(menulist);
        }

        [HttpPost]
        [Route("PostMenus")]
        public IActionResult PostMenus(Menu b){
            db.Menus.Add(b);
            db.SaveChanges();
            return Ok();
        }

        [HttpPut]
        [Route("PutMenus")]
        public IActionResult PutMenus(int id, Menu menu ){
            var menulist=db.Menus.Find(id);
            if(menulist!=null){
                menulist.Name=menu.Name;
                menulist.Description=menu.Description;
                menulist.Price=menu.Price;
                db.Update(menulist);
                db.SaveChanges();
                return Ok();
            }
            else{
                return NotFound("In Valid Input");
            }
        }

        [HttpDelete]
        [Route("DeleteMenu")]
        public IActionResult DeleteMenu(int id){
            var menulist=db.Menus.Find(id);
            if(menulist!=null){
                db.Menus.Remove(menulist);
                db.SaveChanges();
                return Ok();
            }else{
                return NotFound("Id Not Valid");
            }
        }






        [HttpGet]
        [Route("GetOrderDetail")]
        public IActionResult GetOrderDetail(){
            var orderlist=db.OrderDetails;
            return Ok(orderlist);
        }
    }
}