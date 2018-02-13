using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WardForms.Models;
using WardForms.Repository;

namespace WardForms.Controllers
{
    public class ProvincesController : Controller
    {
     //   private ApplicationDbContext db = new ApplicationDbContext();
        ProvincesRepository ProvincesRepo = new ProvincesRepository();

        // GET: Provinces
        public ActionResult Index()
        {
            
            var provinces = ProvincesRepo.GetAllProvinces();

            return View(provinces.ToList());
        }

        // GET: Provinces/Details/5
        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Province province = db.Provinces.Find(id);
            Province province = ProvincesRepo.Get(id);
            if (province == null)
            {
                return HttpNotFound();
            }
            return View(province);
        }

        // GET: Provinces/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Provinces/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProvinceCode,Province1,ProvinceLocal")] Province province)
        {
            if (ModelState.IsValid)
            {
                ProvincesRepo.Add(province);
                ProvincesRepo.save();
                return RedirectToAction("Index");
            }

            return View(province);
        }

        // GET: Provinces/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Province province = ProvincesRepo.Get(id);
           // Province province = db.Provinces.Find(id);
            if (province == null)
            {
                return HttpNotFound();
            }
            return View(province);
        }

        // POST: Provinces/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProvinceCode,Province1,ProvinceLocal")] Province province)
        {
            if (ModelState.IsValid)
            {
                ProvincesRepo.UpdateProvince(province);

                return RedirectToAction("Index");
            }
            return View(province);
        }

        // GET: Provinces/Delete/5
        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Province province = ProvincesRepo.Get(id);
          //  Province province = db.Provinces.Find(id);
            if (province == null)
            {
                return HttpNotFound();
            }
            return View(province);
        }

        // POST: Provinces/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Province province = ProvincesRepo.Get(id);
            //  Province province = db.Provinces.Find(id);
            ProvincesRepo.Remove(province);
            ProvincesRepo.save();
           
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            //if (disposing)
            //{
            //    db.Dispose();
            //}
            //base.Dispose(disposing);
        }
    }
}
