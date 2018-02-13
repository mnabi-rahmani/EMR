using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WardForms.Models;

namespace WardForms.Controllers
{
    public class FacilityContactMechanisimsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: FacilityContactMechanisims
        public ActionResult Index()
        {
            return View(db.FacilityContactMechanisims.ToList());
        }

        // GET: FacilityContactMechanisims/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FacilityContactMechanisim facilityContactMechanisim = db.FacilityContactMechanisims.Find(id);
            if (facilityContactMechanisim == null)
            {
                return HttpNotFound();
            }
            return View(facilityContactMechanisim);
        }

        // GET: FacilityContactMechanisims/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FacilityContactMechanisims/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FMID,FKFCMFacilityID,StartDate,ThruDate")] FacilityContactMechanisim facilityContactMechanisim)
        {
            if (ModelState.IsValid)
            {
                db.FacilityContactMechanisims.Add(facilityContactMechanisim);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(facilityContactMechanisim);
        }

        // GET: FacilityContactMechanisims/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FacilityContactMechanisim facilityContactMechanisim = db.FacilityContactMechanisims.Find(id);
            if (facilityContactMechanisim == null)
            {
                return HttpNotFound();
            }
            return View(facilityContactMechanisim);
        }

        // POST: FacilityContactMechanisims/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FMID,FKFCMFacilityID,StartDate,ThruDate")] FacilityContactMechanisim facilityContactMechanisim)
        {
            if (ModelState.IsValid)
            {
                db.Entry(facilityContactMechanisim).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(facilityContactMechanisim);
        }

        // GET: FacilityContactMechanisims/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FacilityContactMechanisim facilityContactMechanisim = db.FacilityContactMechanisims.Find(id);
            if (facilityContactMechanisim == null)
            {
                return HttpNotFound();
            }
            return View(facilityContactMechanisim);
        }

        // POST: FacilityContactMechanisims/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FacilityContactMechanisim facilityContactMechanisim = db.FacilityContactMechanisims.Find(id);
            db.FacilityContactMechanisims.Remove(facilityContactMechanisim);
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
