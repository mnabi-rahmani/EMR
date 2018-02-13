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
    public class FacilityPartiesController : Controller
    {
        private WardFormsContext db = new WardFormsContext();

        // GET: FacilityParties
        public ActionResult Index()
        {
            return View(db.FacilityParties.ToList());
        }

        // GET: FacilityParties/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FacilityParty facilityParty = db.FacilityParties.Find(id);
            if (facilityParty == null)
            {
                return HttpNotFound();
            }
            return View(facilityParty);
        }

        // GET: FacilityParties/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FacilityParties/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FPID,FKFPFacilityID,FKFPPartyID,FKFPRoleTypeID,FromDate,ThruDate")] FacilityParty facilityParty)
        {
            if (ModelState.IsValid)
            {
                db.FacilityParties.Add(facilityParty);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(facilityParty);
        }

        // GET: FacilityParties/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FacilityParty facilityParty = db.FacilityParties.Find(id);
            if (facilityParty == null)
            {
                return HttpNotFound();
            }
            return View(facilityParty);
        }

        // POST: FacilityParties/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FPID,FKFPFacilityID,FKFPPartyID,FKFPRoleTypeID,FromDate,ThruDate")] FacilityParty facilityParty)
        {
            if (ModelState.IsValid)
            {
                db.Entry(facilityParty).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(facilityParty);
        }

        // GET: FacilityParties/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FacilityParty facilityParty = db.FacilityParties.Find(id);
            if (facilityParty == null)
            {
                return HttpNotFound();
            }
            return View(facilityParty);
        }

        // POST: FacilityParties/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FacilityParty facilityParty = db.FacilityParties.Find(id);
            db.FacilityParties.Remove(facilityParty);
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
