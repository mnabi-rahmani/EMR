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
    public class DataSetSectionElementsController : Controller
    {
        private WardFormsCoreDataModel db = new WardFormsCoreDataModel();

        // GET: DataSetSectionElements
        public ActionResult Index()
        {
            var dataSetSectionElements = db.DataSetSectionElements.Include(d => d.DataElement).Include(d => d.DataSetSection);
            return View(dataSetSectionElements.ToList());
        }

        // GET: DataSetSectionElements/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DataSetSectionElement dataSetSectionElement = db.DataSetSectionElements.Find(id);
            if (dataSetSectionElement == null)
            {
                return HttpNotFound();
            }
            return View(dataSetSectionElement);
        }

        // GET: DataSetSectionElements/Create
        public ActionResult Create()
        {
            ViewBag.FKDSSEDataelementID = new SelectList(db.DataElements, "DEID", "DataElement1");
            ViewBag.FKDSSEDataSetSectionID = new SelectList(db.DataSetSections, "DSSID", "DataSetSectionShortName");
            return View();
        }

        // POST: DataSetSectionElements/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DSSEId,DataSetSectionElementShortName,DataSetSectionElementName,DataSetNameSectionElementPersian,DataSetNameSectionElementPashto,FKDSSEDataSetSectionID,FKDSSEDataelementID")] DataSetSectionElement dataSetSectionElement)
        {
            if (ModelState.IsValid)
            {
                db.DataSetSectionElements.Add(dataSetSectionElement);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.FKDSSEDataelementID = new SelectList(db.DataElements, "DEID", "DataElement1", dataSetSectionElement.FKDSSEDataelementID);
            ViewBag.FKDSSEDataSetSectionID = new SelectList(db.DataSetSections, "DSSID", "DataSetSectionShortName", dataSetSectionElement.FKDSSEDataSetSectionID);
            return View(dataSetSectionElement);
        }

        // GET: DataSetSectionElements/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DataSetSectionElement dataSetSectionElement = db.DataSetSectionElements.Find(id);
            if (dataSetSectionElement == null)
            {
                return HttpNotFound();
            }
            ViewBag.FKDSSEDataelementID = new SelectList(db.DataElements, "DEID", "DataElement1", dataSetSectionElement.FKDSSEDataelementID);
            ViewBag.FKDSSEDataSetSectionID = new SelectList(db.DataSetSections, "DSSID", "DataSetSectionShortName", dataSetSectionElement.FKDSSEDataSetSectionID);
            return View(dataSetSectionElement);
        }

        // POST: DataSetSectionElements/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DSSEId,DataSetSectionElementShortName,DataSetSectionElementName,DataSetNameSectionElementPersian,DataSetNameSectionElementPashto,FKDSSEDataSetSectionID,FKDSSEDataelementID")] DataSetSectionElement dataSetSectionElement)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dataSetSectionElement).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.FKDSSEDataelementID = new SelectList(db.DataElements, "DEID", "DataElement1", dataSetSectionElement.FKDSSEDataelementID);
            ViewBag.FKDSSEDataSetSectionID = new SelectList(db.DataSetSections, "DSSID", "DataSetSectionShortName", dataSetSectionElement.FKDSSEDataSetSectionID);
            return View(dataSetSectionElement);
        }

        // GET: DataSetSectionElements/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DataSetSectionElement dataSetSectionElement = db.DataSetSectionElements.Find(id);
            if (dataSetSectionElement == null)
            {
                return HttpNotFound();
            }
            return View(dataSetSectionElement);
        }

        // POST: DataSetSectionElements/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DataSetSectionElement dataSetSectionElement = db.DataSetSectionElements.Find(id);
            db.DataSetSectionElements.Remove(dataSetSectionElement);
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
