using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Book.Models;

namespace Book.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly BookDbContext bookDbContext;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    // public IActionResult Index()
    // {
    //     var students=bookDbContext.Books.ToList();
    //     return View();
    // }

    //MyDbContext db = new MyDbContext();
    BookDbContext db = new BookDbContext();
        public IActionResult Index()
        {
            var bList = db.Books;
            ViewBag.Count=db.Books.Count();
            return View(ViewBag.Count);
        }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
