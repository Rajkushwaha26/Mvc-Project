using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CODEFIRSTAAP.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CODEFIRSTAAP.Controllers
{
    
    public class CookController : Controller
    {
        BookDBContext db= new BookDBContext();
       
        public IActionResult Index()
        {
            var booklist=db.Books;
            ViewBag.message=booklist.Count();
 
            return View(booklist);
        }
        public IActionResult Create()
        {
            return View();
 
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}