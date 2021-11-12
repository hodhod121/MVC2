using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Projects()
        {
            List<HomeModel> users = new List<HomeModel>();
            users.Add(new HomeModel("Ali", "ali@yahoo.com", "0735689532", 53));
            users.Add(new HomeModel("Benji", "benji@yahoo.com", "0725689535", 13));
            users.Add(new HomeModel("Billy", "billy@yahoo.com", "0755689539", 35));
            users.Add(new HomeModel("Gholi", "gholi@yahoo.com", "0705689536", 25));
            users.Add(new HomeModel("Ghanbar", "hodhod@yahoo.com", "0795689530", 13));
            users.Add(new HomeModel("Nima", "nima@yahoo.com", "0735689534", 50));
            return View(users);
        }
        public IActionResult Privacy()
        {
            return View();
        }
    }
}
