using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SignoZodiacal.Models;
using SignoZodiacal.Services;

namespace SignoZodiacal.Controllers
{
    public class HomeController : Controller
    {
        private readonly ZodiacalSignoServices signoServices = new ZodiacalSignoServices();
        public IActionResult Index()
        {
            
            return View();
        }
        public ViewResult ZodiacalSigno()
        {
            return View();
        }
        [HttpPost]
        public ViewResult ZodiacalSigno(DateTime yourdate)
        {
            var signo = signoServices.GetSignoZodiacalByDate(yourdate);
            return View(signo);
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
}
