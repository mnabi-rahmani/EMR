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
    public class FacilityLocationGeoPiontsController : Controller
    {
        //private ApplicationDbContext db = new ApplicationDbContext();
 
        FacilityGeoLocsRepository FacilityGeoRepo = new FacilityGeoLocsRepository();

      

        // GET: FacilityLocationGeoPionts
        public ActionResult Index()
        {
            // return View(db.FacilityLocationGeoPionts.ToList());
            var facilityGeos = FacilityGeoRepo.GetAllLoc();

            return View(facilityGeos.ToList());
        }

        // GET: FacilityLocationGeoPionts/Details/5
        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            // FacilityLocationGeoPiont facilityLocationGeoPiont = db.FacilityLocationGeoPionts.Find(id);
            FacilityLocationGeoPiont facilityLocationGeoPiont = FacilityGeoRepo.Get(id);
            if (facilityLocationGeoPiont == null)
            {
                return HttpNotFound();
            }
            return View(facilityLocationGeoPiont);
        }

        // GET: FacilityLocationGeoPionts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FacilityLocationGeoPionts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FLGeoPID,Lat,Lan,StartDate,ThruDate,Status,FKFLGPFacilityID,FacilityGeoPiontDescription")] FacilityLocationGeoPiont facilityLocationGeoPiont)
        {
            //if (ModelState.IsValid)
            //{
            //    db.FacilityLocationGeoPionts.Add(facilityLocationGeoPiont);
            //    db.SaveChanges();
            //    return RedirectToAction("Index");
            //}
            if (ModelState.IsValid)
            {

                FacilityGeoRepo.Add(facilityLocationGeoPiont);
                FacilityGeoRepo.save();
                return RedirectToAction("Index");
            }

            return View(facilityLocationGeoPiont);
        }

        // GET: FacilityLocationGeoPionts/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //FacilityLocationGeoPiont facilityLocationGeoPiont = db.FacilityLocationGeoPionts.Find(id);
            FacilityLocationGeoPiont facilityGeo = FacilityGeoRepo.Get(id);
            if (facilityGeo == null)
            {
                return HttpNotFound();
            }
            return View(facilityGeo);
        }

        // POST: FacilityLocationGeoPionts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FLGeoPID,Lat,Lan,StartDate,ThruDate,Status,FKFLGPFacilityID,FacilityGeoPiontDescription")] FacilityLocationGeoPiont facilityLocationGeoPiont)
        {
            //if (ModelState.IsValid)
            //{
            //    db.Entry(facilityLocationGeoPiont).State = EntityState.Modified;
            //    db.SaveChanges();
            //    return RedirectToAction("Index");
            //}
            if (ModelState.IsValid)
            {
                FacilityGeoRepo.UpdateLocs(facilityLocationGeoPiont);

                return RedirectToAction("Index");
            }
            return View(facilityLocationGeoPiont);
        }

        // GET: FacilityLocationGeoPionts/Delete/5
        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //  FacilityLocationGeoPiont facilityLocationGeoPiont = db.FacilityLocationGeoPionts.Find(id);
            FacilityLocationGeoPiont facilityLocationGeoPiont = FacilityGeoRepo.Get(id);
            if (facilityLocationGeoPiont == null)
            {
                return HttpNotFound();
            }
            return View(facilityLocationGeoPiont);
        }

        // POST: FacilityLocationGeoPionts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            //FacilityLocationGeoPiont facilityLocationGeoPiont = db.FacilityLocationGeoPionts.Find(id);
            //db.FacilityLocationGeoPionts.Remove(facilityLocationGeoPiont);
            //db.SaveChanges();
            FacilityLocationGeoPiont facilityLoc = FacilityGeoRepo.Get(id);
            FacilityGeoRepo.Remove(facilityLoc);
            FacilityGeoRepo.save();
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
