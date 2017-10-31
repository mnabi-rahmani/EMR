using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace WardForms.Controllers
{
    public class ElementValuesController : Controller
    {
        private WardFormsCoreDataModel db = new WardFormsCoreDataModel();

        // GET: ElementValues
        public ActionResult Index()
        {
            var elementValues = db.ElementValues.Include(e => e.DataElement);
            return View(elementValues.ToList());
        }

        // GET: ElementValues/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ElementValue elementValue = db.ElementValues.Find(id);
            if (elementValue == null)
            {
                return HttpNotFound();
            }
            return View(elementValue);
        }

        // GET: ElementValues/Create
        public ActionResult Create()
        {
            ViewBag.FKEVDataElementID = new SelectList(db.DataElements, "DEID", "DataElement1");
            return View();
        }

        // POST: ElementValues/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DEVID,DataElementValue,FKEVDataElementID,FKEVServiceID")] ElementValue elementValue)
        {
            if (ModelState.IsValid)
            {
                db.ElementValues.Add(elementValue);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.FKEVDataElementID = new SelectList(db.DataElements, "DEID", "DataElement1", elementValue.FKEVDataElementID);
            return View(elementValue);
        }

        // GET: ElementValues/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ElementValue elementValue = db.ElementValues.Find(id);
            if (elementValue == null)
            {
                return HttpNotFound();
            }
            ViewBag.FKEVDataElementID = new SelectList(db.DataElements, "DEID", "DataElement1", elementValue.FKEVDataElementID);
            return View(elementValue);
        }

        // POST: ElementValues/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DEVID,DataElementValue,FKEVDataElementID,FKEVServiceID")] ElementValue elementValue)
        {
            if (ModelState.IsValid)
            {
                db.Entry(elementValue).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.FKEVDataElementID = new SelectList(db.DataElements, "DEID", "DataElement1", elementValue.FKEVDataElementID);
            return View(elementValue);
        }

        // GET: ElementValues/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ElementValue elementValue = db.ElementValues.Find(id);
            if (elementValue == null)
            {
                return HttpNotFound();
            }
            return View(elementValue);
        }

        // POST: ElementValues/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ElementValue elementValue = db.ElementValues.Find(id);
            db.ElementValues.Remove(elementValue);
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
