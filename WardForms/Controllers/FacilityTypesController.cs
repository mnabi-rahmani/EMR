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
    public class FacilityTypesController : Controller
    {
        //private ApplicationDbContext db = new ApplicationDbContext();
        FacilityTypesRepository FacilityTypesRepo = new FacilityTypesRepository();

        // GET: FacilityTypes
        public ActionResult Index()
        {
            // return View(db.FacilityTypes.ToList());
            var facilityTypes = FacilityTypesRepo.GetAllTypes();

            return View(facilityTypes.ToList());
        }

        // GET: FacilityTypes/Details/5
        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //FacilityType facilityType = db.FacilityTypes.Find(id);
            //if (facilityType == null)
            //{
            //    return HttpNotFound();
            //}
            //return View(facilityType);
            FacilityType facilityType = FacilityTypesRepo.Get(id);

            if (facilityType == null)
            {
                return HttpNotFound();
            }
            return View(facilityType);
        }

        // GET: FacilityTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FacilityTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FacilityTypeID,FacilityType1,FacilityTypeLocal,FacilityTypeDescription,StartDate,ThruDate")] FacilityType facilityType)
        {
            if (ModelState.IsValid)
            {
                FacilityTypesRepo.Add(facilityType);
                //db.FacilityTypes.Add(facilityType);
                FacilityTypesRepo.save();
             //   db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(facilityType);
        }

        // GET: FacilityTypes/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //FacilityType facilityType = db.FacilityTypes.Find(id);
            FacilityType facilityType = FacilityTypesRepo.Get(id);
            if (facilityType == null)
            {
                return HttpNotFound();
            }
            return View(facilityType);
        }

        // POST: FacilityTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FacilityTypeID,FacilityType1,FacilityTypeLocal,FacilityTypeDescription,StartDate,ThruDate")] FacilityType facilityType)
        {
            //if (ModelState.IsValid)
            //{
            //    db.Entry(facilityType).State = EntityState.Modified;
            //    db.SaveChanges();
            //    return RedirectToAction("Index");
            //}
            if (ModelState.IsValid)
            {
                FacilityTypesRepo.UpdateFacility(facilityType);

                return RedirectToAction("Index");
            }
            return View(facilityType);
        }

        // GET: FacilityTypes/Delete/5
        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            //FacilityType facilityType = db.FacilityTypes.Find(id);
            FacilityType facilityType = FacilityTypesRepo.Get(id);
            if (facilityType == null)
            {
                return HttpNotFound();
            }
            return View(facilityType);
        }

        // POST: FacilityTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {

            //FacilityType facilityType = db.FacilityTypes.Find(id);
            //db.FacilityTypes.Remove(facilityType);
            //db.SaveChanges();

            FacilityType facilityType = FacilityTypesRepo.Get(id);
            FacilityTypesRepo.Remove(facilityType);
            FacilityTypesRepo.save();
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
