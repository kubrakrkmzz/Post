using Microsoft.AspNetCore.Mvc;
using Post.Data;
using Post.Models;
using System.Collections.Generic;
using System.Linq;

namespace Post.Controllers
{

    //NOT!!! Sayfada butonlar birden fazla çalışmıyor çalışma hatası veriyor. View-> Depart -> Index teki
    //IENumberable ile oluşturulan kısımda sıkıntı olabilir.Bak mutlaka!!

    //NOT2 : http://yazilimnotlari.com/makale-16-auto-increment-alani-resetlemek Veri silme ekleme işlemlerinde Id nin otomatik olarak artması için düzenleme yap.
    public class DepartController : Controller
    {
        private readonly Context _db;

        public DepartController(Context db)
        {
            _db = db;
        }


        public IActionResult Index() //buradaki index, üzerine eklemiş olduğumuz _SideLayout'u kullanıcak.
        {

            List<Department> listele = _db.Departments.ToList();

            return View(listele);
        }

        [HttpGet]
        public IActionResult NewDepart()
        {

            return View();
        }

        [HttpPost]
        public IActionResult NewDepart(Department d)
        {
            //yeni bir class oluştur ve gelen depart bilgiilerini oraya aktar ondan sonra dönüştür. Repostory ye bak kursDavette
            _db.Departments.Add(d);
            _db.SaveChanges();
            return RedirectToAction("Index");

           // return View();
        }

        public IActionResult DeleteDepart(int id)
        {
            var dep = _db.Departments.Find(id);
            _db.Departments.Remove(dep);
            _db.SaveChanges();
            return RedirectToAction("Index");
            //index sayfasında butonun nereye gideceğini bağlayacağım.

        }

        public IActionResult ViewDepart(int id)
        {
            var dp = _db.Departments.Find(id);
            return View("ViewDepart",dp);
        }

        public IActionResult UpdateDepart(Department d)
        {
            var depa = _db.Departments.Find(d.DepartId);
            depa.DepartName = d.DepartName;
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult DetailsDepart(int id)
        {
            var detay = _db.Personals.Where(x => x.DepartId == id).ToList();
            var dpt = _db.Departments.Where(x => x.DepartId == id).Select(y => y.DepartName).FirstOrDefault();
            ViewBag.dptname = dpt;
            return View(detay);
        }

    }
}
