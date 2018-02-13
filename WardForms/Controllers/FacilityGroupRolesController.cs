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
    public class FacilityGroupRolesController : Controller
    {
        private WardFormsContext db = new WardFormsContext();

        // GET: FacilityGroupRoles
        public ActionResult Index()
        {
            return View(db.FacilityGroupRoles.ToList());
        }

        // GET: FacilityGroupRoles/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FacilityGroupRole facilityGroupRole = db.FacilityGroupRoles.Find(id);
            if (facilityGroupRole == null)
            {
                return HttpNotFound();
            }
            return View(facilityGroupRole);
        }

        // GET: FacilityGroupRoles/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FacilityGroupRoles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FGRId,FKFGRFacilityGroupID,FKFGRFacilityPartyID,FKFGRRoleTypeID,StartDate,ThruDate")] FacilityGroupRole facilityGroupRole)
        {
            if (ModelState.IsValid)
            {
                db.FacilityGroupRoles.Add(facilityGroupRole);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(facilityGroupRole);
        }

        // GET: FacilityGroupRoles/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FacilityGroupRole facilityGroupRole = db.FacilityGroupRoles.Find(id);
            if (facilityGroupRole == null)
            {
                return HttpNotFound();
            }
            return View(facilityGroupRole);
        }

        // POST: FacilityGroupRoles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FGRId,FKFGRFacilityGroupID,FKFGRFacilityPartyID,FKFGRRoleTypeID,StartDate,ThruDate")] FacilityGroupRole facilityGroupRole)
        {
            if (ModelState.IsValid)
            {
                db.Entry(facilityGroupRole).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(facilityGroupRole);
        }

        // GET: FacilityGroupRoles/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FacilityGroupRole facilityGroupRole = db.FacilityGroupRoles.Find(id);
            if (facilityGroupRole == null)
            {
                return HttpNotFound();
            }
            return View(facilityGroupRole);
        }

        // POST: FacilityGroupRoles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FacilityGroupRole facilityGroupRole = db.FacilityGroupRoles.Find(id);
            db.FacilityGroupRoles.Remove(facilityGroupRole);
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
