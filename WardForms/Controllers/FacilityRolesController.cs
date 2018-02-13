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
    public class FacilityRolesController : Controller
    {
        private WardFormsContext db = new WardFormsContext();

        // GET: FacilityRoles
        public ActionResult Index()
        {
            return View(db.FacilityRoles.ToList());
        }

        // GET: FacilityRoles/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FacilityRole facilityRole = db.FacilityRoles.Find(id);
            if (facilityRole == null)
            {
                return HttpNotFound();
            }
            return View(facilityRole);
        }

        // GET: FacilityRoles/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FacilityRoles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FacilityRoleID,FKFRFacilityID,FKFRPartyID,FKFRRoleTypeID,StartDate,ThruDate")] FacilityRole facilityRole)
        {
            if (ModelState.IsValid)
            {
                db.FacilityRoles.Add(facilityRole);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(facilityRole);
        }

        // GET: FacilityRoles/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FacilityRole facilityRole = db.FacilityRoles.Find(id);
            if (facilityRole == null)
            {
                return HttpNotFound();
            }
            return View(facilityRole);
        }

        // POST: FacilityRoles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FacilityRoleID,FKFRFacilityID,FKFRPartyID,FKFRRoleTypeID,StartDate,ThruDate")] FacilityRole facilityRole)
        {
            if (ModelState.IsValid)
            {
                db.Entry(facilityRole).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(facilityRole);
        }

        // GET: FacilityRoles/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FacilityRole facilityRole = db.FacilityRoles.Find(id);
            if (facilityRole == null)
            {
                return HttpNotFound();
            }
            return View(facilityRole);
        }

        // POST: FacilityRoles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FacilityRole facilityRole = db.FacilityRoles.Find(id);
            db.FacilityRoles.Remove(facilityRole);
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
