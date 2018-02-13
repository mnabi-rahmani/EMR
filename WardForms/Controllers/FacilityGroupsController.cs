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
    public class FacilityGroupsController : Controller
    {
        private WardFormsContext db = new WardFormsContext();

        // GET: FacilityGroups
        public ActionResult Index()
        {
            return View(db.FacilityGroups.ToList());
        }

        // GET: FacilityGroups/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FacilityGroup facilityGroup = db.FacilityGroups.Find(id);
            if (facilityGroup == null)
            {
                return HttpNotFound();
            }
            return View(facilityGroup);
        }

        // GET: FacilityGroups/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FacilityGroups/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FGID,FKFGFacilityGroupTypeID,FacilityGroup1,FacilityGroupLocal,FKFGFacilityID")] FacilityGroup facilityGroup)
        {
            if (ModelState.IsValid)
            {
                db.FacilityGroups.Add(facilityGroup);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(facilityGroup);
        }

        // GET: FacilityGroups/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FacilityGroup facilityGroup = db.FacilityGroups.Find(id);
            if (facilityGroup == null)
            {
                return HttpNotFound();
            }
            return View(facilityGroup);
        }

        // POST: FacilityGroups/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FGID,FKFGFacilityGroupTypeID,FacilityGroup1,FacilityGroupLocal,FKFGFacilityID")] FacilityGroup facilityGroup)
        {
            if (ModelState.IsValid)
            {
                db.Entry(facilityGroup).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(facilityGroup);
        }

        // GET: FacilityGroups/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FacilityGroup facilityGroup = db.FacilityGroups.Find(id);
            if (facilityGroup == null)
            {
                return HttpNotFound();
            }
            return View(facilityGroup);
        }

        // POST: FacilityGroups/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FacilityGroup facilityGroup = db.FacilityGroups.Find(id);
            db.FacilityGroups.Remove(facilityGroup);
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
