using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using pin_projekt.Models;

namespace pin_projekt.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
       

        public IActionResult About()
        {
            ViewData["Message"] = "O nama";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Kontaktirajte nas";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult BasicQuerySyntax() {
   
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private void DeleteCookies() {
            foreach (var cookie in HttpContext.Request.Cookies) {
                Response.Cookies.Delete(cookie.Key);
            }

        }


    }
}
