using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WardFormsCore.DataModel;

namespace WardForms.Controllers
{
    public class PatientVisitsController : Controller
    {
        private WardFormsCoreDataModel db = new WardFormsCoreDataModel();

        // GET: PatientVisits
        public ActionResult Index()
        {
            var patientVisits = db.PatientVisits.Include(p => p.Patient);
            return View(patientVisits.ToList());
        }

        // GET: PatientVisits/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PatientVisit patientVisit = db.PatientVisits.Find(id);
            if (patientVisit == null)
            {
                return HttpNotFound();
            }
            return View(patientVisit);
        }

        // GET: PatientVisits/Create
        public ActionResult Create()
        {
            ViewBag.PersonRoleID = new SelectList(db.Patients, "PersonRoleID", "PersonRoleID");
            return View();
        }

        // POST: PatientVisits/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "VisitID,FromDate,ThruDate,PersonRoleID")] PatientVisit patientVisit)
        {
            if (ModelState.IsValid)
            {
                db.PatientVisits.Add(patientVisit);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.PersonRoleID = new SelectList(db.Patients, "PersonRoleID", "PersonRoleID", patientVisit.PersonRoleID);
            return View(patientVisit);
        }

        // GET: PatientVisits/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PatientVisit patientVisit = db.PatientVisits.Find(id);
            if (patientVisit == null)
            {
                return HttpNotFound();
            }
            ViewBag.PersonRoleID = new SelectList(db.Patients, "PersonRoleID", "PersonRoleID", patientVisit.PersonRoleID);
            return View(patientVisit);
        }

        // POST: PatientVisits/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "VisitID,FromDate,ThruDate,PersonRoleID")] PatientVisit patientVisit)
        {
            if (ModelState.IsValid)
            {
                db.Entry(patientVisit).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PersonRoleID = new SelectList(db.Patients, "PersonRoleID", "PersonRoleID", patientVisit.PersonRoleID);
            return View(patientVisit);
        }

        // GET: PatientVisits/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PatientVisit patientVisit = db.PatientVisits.Find(id);
            if (patientVisit == null)
            {
                return HttpNotFound();
            }
            return View(patientVisit);
        }

        // POST: PatientVisits/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PatientVisit patientVisit = db.PatientVisits.Find(id);
            db.PatientVisits.Remove(patientVisit);
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
