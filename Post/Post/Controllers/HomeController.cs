using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Post.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Post.Data;

namespace Post.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Context _context;

        public HomeController(ILogger<HomeController> logger, Context context)
        {
            _logger = logger;
           _context = context;
        }

        public IActionResult Index()
        {
            /* Users a = new Users();
             a.UserName = "Kkmaz";
             a.Name = "Kubra";
             a.SurName = "Korkmaz";
             a.IdentificationNumber = "262626262";
             a.Address = "adsasdasd 85845dda";
             a.Email = "adsadsdsas";
             a.Phone = "52266562656";
             a.Gender = true;
             _context.Users.Add(a);
             _context.SaveChanges();*/

            _context.Users.Add(new Users
            {
                UserName = "addsdsa",
                Name = "adass",
                SurName = "awds",
                IdentificationNumber = "5559656",
                Address = "sedfddsfds",
                Email = "asfdassa",
                Phone = "5165232633",
                Gender = true

            }) ;
           _context.SaveChanges();
            List<Users> user = _context.Users.ToList(); //Tüm verileri getirir.
            List<Users> usera =_context.Users.Where(x => x.Name.Equals("Kubra") && x.UserName=="Kkmaz").ToList();
            //var user = _context.Users.Where(x => x.Name == "Kubra" && x.UserName == "Kkmaz").ToList(); Aynı şey yukarıdakiyle
            //Equals ve çift eşittir aynı



            return View();
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
