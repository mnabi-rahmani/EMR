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
    public class FacilitiesController : Controller
    {
        //private ApplicationDbContext db = new ApplicationDbContext();

        FacilitiesRepository FacilitiesRepo = new FacilitiesRepository();

        // GET: Facilities
        public ActionResult Index()
        {
            return View(FacilitiesRepo.GetAll().ToList());
        }

        // GET: Facilities/Details/5
        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Facility facility = FacilitiesRepo.Get(id);
            if (facility == null)
            {
                return HttpNotFound();
            }
            return View(facility);
        }

        //// GET: Facilities/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Facilities/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "FID,FKFFacilityTypeID,FacilityName,FacilityNameLocal,FacilityDescription,EstablishmentDate,FKFDisctictCode,FKFProvinceCode")] Facility facility)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Facilities.Add(facility);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(facility);
        //}

        //// GET: Facilities/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Facility facility = db.Facilities.Find(id);
        //    if (facility == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(facility);
        //}

        //// POST: Facilities/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "FID,FKFFacilityTypeID,FacilityName,FacilityNameLocal,FacilityDescription,EstablishmentDate,FKFDisctictCode,FKFProvinceCode")] Facility facility)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(facility).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(facility);
        //}

        //// GET: Facilities/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Facility facility = db.Facilities.Find(id);
        //    if (facility == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(facility);
        //}

        //// POST: Facilities/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    Facility facility = db.Facilities.Find(id);
        //    db.Facilities.Remove(facility);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    
        //}
    }
}
