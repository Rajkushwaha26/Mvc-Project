// using System;
// using System.Collections.Generic;
// using System.Diagnostics;
// using System.Linq;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Mvc;
// using Microsoft.Extensions.Logging;
// using System.ComponentModel.DataAnnotations;


// namespace CODEFIRSTAAP.Controllers
// {
    

//         public IActionResult Index()
//         {
//             return View();
//         }
//         public IActionResult Login()
//         {
//             LoginViewModel model = new LoginViewModel();
//             if(RequestDelegate.Cookies["userCookie"]!=null){
//                 model.UserName=RequestDelegate.Cokkies["userCookie"].ToString();
//             }
//             return View();
//         }

//         [HttpPost]
//         public IActionResult Login(LoginViewModel login){
//             if(login.UserName==login.Password){
//                 if(login.RememberMe==true){
//                     CookieOptions options = new CookieOptions();
//                     options.Expires=DateTime.Now.AddDays(3);
//                     Response.Cookies.Append("userCookie",login.UserName,options);
//                 }
//                 RedirectToAction("Employee","Index");
//             }
//         }

//         [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
//         public IActionResult Error()
//         {
//             return View("Error!");
//         }
//     }
// }