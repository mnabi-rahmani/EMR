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
    public class PurposeTypesController : Controller
    {
        private WardFormsCoreDataModel db = new WardFormsCoreDataModel();

        // GET: PurposeTypes
        public ActionResult Index()
        {
            return View(db.PurposeTypes.ToList());
        }

        // GET: PurposeTypes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PurposeType purposeType = db.PurposeTypes.Find(id);
            if (purposeType == null)
            {
                return HttpNotFound();
            }
            return View(purposeType);
        }

        // GET: PurposeTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PurposeTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PurposeID,Purpose,PurposeLocal")] PurposeType purposeType)
        {
            if (ModelState.IsValid)
            {
                db.PurposeTypes.Add(purposeType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(purposeType);
        }

        // GET: PurposeTypes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PurposeType purposeType = db.PurposeTypes.Find(id);
            if (purposeType == null)
            {
                return HttpNotFound();
            }
            return View(purposeType);
        }

        // POST: PurposeTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PurposeID,Purpose,PurposeLocal")] PurposeType purposeType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(purposeType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(purposeType);
        }

        // GET: PurposeTypes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PurposeType purposeType = db.PurposeTypes.Find(id);
            if (purposeType == null)
            {
                return HttpNotFound();
            }
            return View(purposeType);
        }

        // POST: PurposeTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PurposeType purposeType = db.PurposeTypes.Find(id);
            db.PurposeTypes.Remove(purposeType);
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
