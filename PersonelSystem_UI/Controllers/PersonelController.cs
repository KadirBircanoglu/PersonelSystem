using PersonelSystem_BL;
using PersonelSystem_DL.Repositories;
using PersonelSystem_EL.Entities;
using System;
using System.Web.Mvc;

namespace PersonelSystem_UI.Controllers
{
    public class PersonelController : Controller
    {
        // GET: Personel

        PersonelManager pm = new PersonelManager(new PersonelRepo());
        public ActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public ActionResult GetPersonelList()
        {
            try
            {
                var personelValues = pm.GetPersonelList();
                return View(personelValues);
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Personel listesi yüklenemedi. Daha sonra tekrar deneyiniz.");
                return View();

            }
        }

        [HttpGet]
        public ActionResult AddNewPersonel() 
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddNewPersonel(Personel personel)
        {
            try
            {
                personel.IsActive = true;
                pm.PersonelAdd(personel);
                return RedirectToAction("GetPersonelList");

            }
            catch (Exception)
            {
                ModelState.AddModelError("","Ekleme başarısız! Tekrar deneyiniz.");
                return View();
            }
        }

        public ActionResult DeletePersonel(int id)
        {
            var personelValue = pm.GetPersonel(id);
            pm.PersonelDelete(personelValue);
            return RedirectToAction("GetPersonelList");
        }

        [HttpGet]
        public ActionResult UpdatePersonel(int id)
        {
            var personelValue = pm.GetPersonel(id);
            return View(personelValue); // Değişkenle beraber dön!
        }

        [HttpPost]
        public ActionResult UpdatePersonel(Personel personel)
        {
            personel.IsActive = true;
            pm.PersonelUpdate(personel);
            return RedirectToAction("GetPersonelList");
        }

    }
}