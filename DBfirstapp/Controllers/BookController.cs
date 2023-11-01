using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using DBfirstapp.Models;
namespace DBfirstapp.Controllers
{
    
    public class BookController : Controller
    {
        RanuDbContext db = new RanuDbContext();

        public IActionResult Index()
        {
            var booklist = db.Cooks;
            ViewBag.message=booklist.Count();
            return View(booklist);
        }

        public IActionResult Create(){
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}