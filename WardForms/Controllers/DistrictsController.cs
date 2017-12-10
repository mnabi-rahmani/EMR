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
    public class DistrictsController : Controller
    {
        DistrictsRepository DistrictsRepo = new DistrictsRepository();

        // GET: Districts
        public ActionResult Index()
        {
            // var districts = db.Districts.Include(d => d.Province);
            var districts = DistrictsRepo.GetAllDistricts();
            
            return View(districts.ToList());
        }

        // GET: Districts/Details/5
        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //   District district = db.Districts.Find(id);
        //    District district = DistrictsRepo.Context.Districts.Find(id);
            District district = DistrictsRepo.Get(id);

            if (district == null)
            {
                return HttpNotFound();
            }
            return View(district);
        }

        // GET: Districts/Create
        public ActionResult Create()
        {
            ViewBag.ProvinceCode = new SelectList(DistrictsRepo.Context.Provinces, "ProvinceCode", "Province1");
            return View();
        }

        // POST: Districts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DistrictCode,District1,DistrictLocal,ProvinceCode")] District district)
        {
            if (ModelState.IsValid)
            {
                DistrictsRepo.Add(district);
                DistrictsRepo.save();
               // db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ProvinceCode = new SelectList(DistrictsRepo.Context.Provinces, "ProvinceCode", "Province1", district.ProvinceCode);
            return View(district);
        }

        // GET: Districts/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            District district = DistrictsRepo.Get(id);
            if (district == null)
            {
                return HttpNotFound();
            }
            ViewBag.ProvinceCode = new SelectList(DistrictsRepo.Context.Provinces, "ProvinceCode", "Province1", district.ProvinceCode);
            return View(district);
        }

        // POST: Districts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DistrictCode,District1,DistrictLocal,ProvinceCode")] District district)
        {
            if (ModelState.IsValid)
            {
                DistrictsRepo.Context.Entry(district).State = EntityState.Modified;
                DistrictsRepo.save();
                return RedirectToAction("Index");
            }
            ViewBag.ProvinceCode = new SelectList(DistrictsRepo.Context.Provinces, "ProvinceCode", "Province1", district.ProvinceCode);
            return View(district);
        }

        // GET: Districts/Delete/5
        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            District district = DistrictsRepo.Get(id);
            if (district == null)
            {
                return HttpNotFound();
            }
            return View(district);
        }

        // POST: Districts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            District district = DistrictsRepo.Get(id);
            DistrictsRepo.Remove(district);
            DistrictsRepo.save();
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
