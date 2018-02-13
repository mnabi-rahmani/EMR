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
    public class FacilityContactMechanisimPurposesController : Controller
    {
        //private ApplicationDbContext db = new ApplicationDbContext();
        FacilityContactMechPurposesRepository FacConMechPurRepo = new FacilityContactMechPurposesRepository();

        // GET: FacilityContactMechanisimPurposes
        public ActionResult Index()
        {
        
            var purposes = FacConMechPurRepo.GetAllPurposes();

            return View(purposes.ToList());
        }

        // GET: FacilityContactMechanisimPurposes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FacilityContactMechanisimPurpose facilityContactMechanisimPurpose = db.FacilityContactMechanisimPurposes.Find(id);
            if (facilityContactMechanisimPurpose == null)
            {
                return HttpNotFound();
            }
            return View(facilityContactMechanisimPurpose);
        }

        // GET: FacilityContactMechanisimPurposes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FacilityContactMechanisimPurposes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FCMPID,StartDate,ThruDate,ContactPurposeType,FKFCMPFCMID")] FacilityContactMechanisimPurpose facilityContactMechanisimPurpose)
        {
            if (ModelState.IsValid)
            {
                db.FacilityContactMechanisimPurposes.Add(facilityContactMechanisimPurpose);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(facilityContactMechanisimPurpose);
        }

        // GET: FacilityContactMechanisimPurposes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FacilityContactMechanisimPurpose facilityContactMechanisimPurpose = db.FacilityContactMechanisimPurposes.Find(id);
            if (facilityContactMechanisimPurpose == null)
            {
                return HttpNotFound();
            }
            return View(facilityContactMechanisimPurpose);
        }

        // POST: FacilityContactMechanisimPurposes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FCMPID,StartDate,ThruDate,ContactPurposeType,FKFCMPFCMID")] FacilityContactMechanisimPurpose facilityContactMechanisimPurpose)
        {
            if (ModelState.IsValid)
            {
                db.Entry(facilityContactMechanisimPurpose).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(facilityContactMechanisimPurpose);
        }

        // GET: FacilityContactMechanisimPurposes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FacilityContactMechanisimPurpose facilityContactMechanisimPurpose = db.FacilityContactMechanisimPurposes.Find(id);
            if (facilityContactMechanisimPurpose == null)
            {
                return HttpNotFound();
            }
            return View(facilityContactMechanisimPurpose);
        }

        // POST: FacilityContactMechanisimPurposes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FacilityContactMechanisimPurpose facilityContactMechanisimPurpose = db.FacilityContactMechanisimPurposes.Find(id);
            db.FacilityContactMechanisimPurposes.Remove(facilityContactMechanisimPurpose);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
