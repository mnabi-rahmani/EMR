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
    public class FacilityGroupTypesController : Controller
    {
        private WardFormsContext db = new WardFormsContext();

        // GET: FacilityGroupTypes
        public ActionResult Index()
        {
            return View(db.FacilityGroupTypes.ToList());
        }

        // GET: FacilityGroupTypes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FacilityGroupType facilityGroupType = db.FacilityGroupTypes.Find(id);
            if (facilityGroupType == null)
            {
                return HttpNotFound();
            }
            return View(facilityGroupType);
        }

        // GET: FacilityGroupTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FacilityGroupTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FGTID,FacilityGroupType1,FacilityGroupTypeLocal,FacilityGroupTypeDescription,FKFGTFacilityID")] FacilityGroupType facilityGroupType)
        {
            if (ModelState.IsValid)
            {
                db.FacilityGroupTypes.Add(facilityGroupType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(facilityGroupType);
        }

        // GET: FacilityGroupTypes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FacilityGroupType facilityGroupType = db.FacilityGroupTypes.Find(id);
            if (facilityGroupType == null)
            {
                return HttpNotFound();
            }
            return View(facilityGroupType);
        }

        // POST: FacilityGroupTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FGTID,FacilityGroupType1,FacilityGroupTypeLocal,FacilityGroupTypeDescription,FKFGTFacilityID")] FacilityGroupType facilityGroupType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(facilityGroupType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(facilityGroupType);
        }

        // GET: FacilityGroupTypes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FacilityGroupType facilityGroupType = db.FacilityGroupTypes.Find(id);
            if (facilityGroupType == null)
            {
                return HttpNotFound();
            }
            return View(facilityGroupType);
        }

        // POST: FacilityGroupTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FacilityGroupType facilityGroupType = db.FacilityGroupTypes.Find(id);
            db.FacilityGroupTypes.Remove(facilityGroupType);
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
