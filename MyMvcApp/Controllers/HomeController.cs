using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyMvcApp.Models;

using System.Data.SqlClient;

namespace MyMvcApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

   // public ViewResult Index()

    
        // var str = "Welcome to the ASP.NET CORE MVC APP";
        // ViewData["message"] = str;


        // ViewBag.message2="ASP.net CORE entity frambork.";

        // List<string> strList = new List<string>{

        //     "AAAAAA","GGGGGGGGGG","RRRR","JJJJJJJJJJJJJJ";
        // 

        // 
        public ViewResult Create(){
            return View();
        }
    
        public ViewResult Index()

    {

        List<Employee> empList=new List<Employee>();

        Employee emp;

        string conStr="server=localhost;database=LtiDB;uid=sa;password=examlyMssql@123";

        SqlConnection con=new SqlConnection(conStr);

        con.Open();

        string str=$"select * from employees";

        SqlCommand cmd=new SqlCommand(str,con);

        SqlDataReader reader=cmd.ExecuteReader();

        while(reader.Read()==true)

        {

            emp=new Employee();

            emp.EmployeeId=reader.GetInt32(0);

            emp.EmployeeName=reader.GetString(1);

           emp.Salary=(int)reader.GetDecimal(2);

            emp.joinDate=reader.GetDateTime(3);

            empList.Add(emp);

 

        }

 

        reader.Close();

        con.Close();

        con.Dispose();
                





        // {
        //     new Employee{EmployeeId=101,EmployeeName="aaaba",Salary=3333,joinDate=DateTime.Parse("12-feb-2023")},
        //     new Employee{EmployeeId=102,EmployeeName="aaaa",Salary=3333,joinDate=DateTime.Parse("11-may-2023")}


        
        
        return View(empList);


    }
   // public stored





    //     Employee empObj = new Employee{
    //         EmloyeeId = 101,
    //         EmployeeName = "AAAAAAAAA",
    //         Salary = 274678,
    //         JoinDate = DateTime.Parse("12-dec-2023")
    //     };
    //     return View(empObj);
    // }
        
    //     ViewBage.Names
    //     return View();
    // }

//     public IActionResult Privacy()
//     {
//         return View();
//     }

//     public IActionResult ContactUs(){
//         return View();
//     }

//     public ContentResult Content(){
//         return Content("welcome to the ASP.NET MVC");

//     }
//     public FileResult  FileDownload(){
//         return File("~/audios/karaoke.mp3", "audio/mp3", "myaudio.mp3");
//     }

//     public RedirectResult Redirect(){
//         return Redirect("http://www.mail.com");
//     }
// public JsonResult Json(){
//         List<string> obj = new List<string>{"Raj", "Shid","Aksha"};
//         return Json(obj);
//     }









    

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

}