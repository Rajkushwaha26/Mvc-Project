using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BLood.Models;

namespace BLood.Controllers
{
    //[Route("[controller]")]
    public class BloodController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();

        public IActionResult Index()
        {
            var donerlist=db.BloodDonors;


            return View(donerlist);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(BloodDonor b){
            db.BloodDonors.Add(b);
            db.SaveChanges();

            return View();
        }

        public IActionResult Delete(int id){
            var donordelete =  db.BloodDonors.Find(id);
            if(donordelete!=null ){
                db.BloodDonors.Remove(donordelete);
                db.SaveChanges();

            }
            return RedirectToAction("Index");


            return View();
        }
        

        public IActionResult Edit(int id)
        {
          
            var emp = db.BloodDonors.FirstOrDefault(e => e.ID == id);
            if(emp!=null)
            {
                return View(emp);
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
        [HttpPost]
        public IActionResult Edit(BloodDonor newbldObj)
        {
            db.Update(newbldObj);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}