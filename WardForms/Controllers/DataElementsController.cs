using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WardFormsCore.Data;

namespace WardForms.Controllers
{
    public class DataElementsController : Controller
    {
        private WardFormsCoreDataModel db = new WardFormsCoreDataModel();

        // GET: DataElements
        public ActionResult Index()
        {
            var dataElements = db.DataElements.Include(d => d.DataClassfication);
            return View(dataElements.ToList());
        }

        // GET: DataElements/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DataElement dataElement = db.DataElements.Find(id);
            if (dataElement == null)
            {
                return HttpNotFound();
            }
            return View(dataElement);
        }

        // GET: DataElements/Create
        public ActionResult Create()
        {
            ViewBag.FKDEDataSetClassficationID = new SelectList(db.DataClassfications, "DataClsID", "DataClassfication1");
            return View();
        }

        // POST: DataElements/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DEID,DataElement1,DataElementPersian,DataElementPashto,FKDEDataSetClassficationID,SortOrder,DataElementStatus")] DataElement dataElement)
        {
            if (ModelState.IsValid)
            {
                db.DataElements.Add(dataElement);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.FKDEDataSetClassficationID = new SelectList(db.DataClassfications, "DataClsID", "DataClassfication1", dataElement.FKDEDataSetClassficationID);
            return View(dataElement);
        }

        // GET: DataElements/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DataElement dataElement = db.DataElements.Find(id);
            if (dataElement == null)
            {
                return HttpNotFound();
            }
            ViewBag.FKDEDataSetClassficationID = new SelectList(db.DataClassfications, "DataClsID", "DataClassfication1", dataElement.FKDEDataSetClassficationID);
            return View(dataElement);
        }

        // POST: DataElements/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DEID,DataElement1,DataElementPersian,DataElementPashto,FKDEDataSetClassficationID,SortOrder,DataElementStatus")] DataElement dataElement)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dataElement).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.FKDEDataSetClassficationID = new SelectList(db.DataClassfications, "DataClsID", "DataClassfication1", dataElement.FKDEDataSetClassficationID);
            return View(dataElement);
        }

        // GET: DataElements/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DataElement dataElement = db.DataElements.Find(id);
            if (dataElement == null)
            {
                return HttpNotFound();
            }
            return View(dataElement);
        }

        // POST: DataElements/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DataElement dataElement = db.DataElements.Find(id);
            db.DataElements.Remove(dataElement);
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
