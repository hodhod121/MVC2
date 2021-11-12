using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.Utility;

namespace WebApplication1.Controllers
{
    public class DoctorController : Controller
    {      
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult FeberCheck()
        {
            return View();
        }
        TempResult tempResult = new TempResult();
        [HttpPost]
        public IActionResult Index(DoctorModel temprature)
        {           

            ViewBag.TempResult = tempResult.GetResult(ref temprature);
            return View();
        }
    }
}
