using Microsoft.AspNetCore.Mvc;
using Post.Models;
using Microsoft.EntityFrameworkCore;
using Post.Data;
using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Post.Controllers
{
    public class PersonController : Controller
    {
        private readonly Context _db;

        public PersonController (Context db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var degerler = _db.Personals.Include(x=> x.depart).ToList();
            return View(degerler);
        }

        [HttpGet]
        public IActionResult NewPerson()
        {
            List<SelectListItem> degerler = (from x in _db.Departments.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = x.DepartName ,
                                                 Value = x.DepartId.ToString()
                                             }).ToList();

            ViewBag.dgr = degerler;
            return View();
        }

        public IActionResult NewPerson(Personal p)
        {
            var per = _db.Departments.Where(x => x.DepartId == p.depart.DepartId).FirstOrDefault();
            p.depart = per;
            _db.Personals.Add(p);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
       

    }
}
