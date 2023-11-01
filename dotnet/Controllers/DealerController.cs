using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using dotnet.Models;

namespace dotnet.Controllers
{
    public class DealerController : Controller
    {
        ApplicationDbContext db ;
        public DealerController(ApplicationDbContext context){
            this.db=context;
        }
        public IActionResult Index()
        {
            var item = db.Dealers;

            return View(item);
        }

        [HttpGet]
        public IActionResult Create(){

            return View();
        }

        [HttpPost]
        public IActionResult Create(Dealer dd){
            db.Dealers.Add(dd);
            db.SaveChanges();
            return View();
        }
        public IActionResult Delete(int id){
            var delet = db.Dealers.Find(id);
            if(delet!=null){
                db.Dealers.Remove(delet);
                db.SaveChanges();
                
            }else{
                return View();
            }
            return RedirectToAction("Index");
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id){
            var deta = db.Dealers.FirstOrDefault(e=>e.ID==id);
            if(deta!=null){
                return View(deta);
            }else{
                return RedirectToAction("Index");
            }
            
        }

        [HttpPost]
        public IActionResult Edit(Dealer newobj){
            db.Update(newobj);
            db.SaveChanges();
            return RedirectToAction ("Index");

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}