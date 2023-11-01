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
        ApplicationDbContext db = new ApplicationDbContext();

        public IActionResult Index()
        {
            var item = db.Dealers;

            return View(item);
        }
        public IActionResult Create(){
            return View();
        }
        public IActionResult Delete(){
            return View();
        }
        public IActionResult Edit(){
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}