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
    public class UserController : ControllerBase
    {
        private readonly ApplicationDbContext db;
        public UserController(ApplicationDbContext context){
            this.db=context;
        }

        
        [HttpGet]
        [Route("GetUsers")]
        public IActionResult GetUsers(){
            var ullist=db.Users;
            return Ok(ullist);
        }

        [HttpPost]
        [Route("PostUsers")]
        public IActionResult PostUsers(User U){
            db.Users.Add(U);
            db.SaveChanges();
            return Ok();
        }

        
        [HttpPut]
        [Route("PutUsers")]
        public IActionResult PutUsers(int id, User user ){
            var ullist=db.Users.Find(id);
            if(ullist!=null){
                ullist.UserName=user.UserName;
                ullist.Password=user.Password;
                ullist.Email=user.Email;
                ullist.RoleId=user.RoleId;

                db.Update(ullist);
                db.SaveChanges();
                return Ok();
            }
            else{
                return NotFound("In Valid Input");
            }
        }

        [HttpDelete]
        [Route("DeleteUser")]
        public IActionResult DeleteUser(int id){
            var ullist=db.Users.Find(id);
            if(ullist!=null){
                db.Users.Remove(ullist);
                db.SaveChanges();
                return Ok();
            }else{
                return NotFound("Id Not Valid");
            }
        }

        //Role

        [HttpGet]
        [Route("GetRoles")]
        public IActionResult GetRoles(){
            var rolelist=db.Roles;
            return Ok(rolelist);
        }

        [HttpPost]
        [Route("PostRoles")]
        public IActionResult PostRoles(Role R){
            db.Roles.Add(R);
            db.SaveChanges();
            return Ok();
        }


    }
}