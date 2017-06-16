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
    public class AllElementsController : Controller
    {
        private WardFormsCoreDataModel db = new WardFormsCoreDataModel();

        // GET: AllElements
        public ActionResult Index()
        {
            return View(db.AllElements.ToList());
        }

        // GET: AllElements/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AllElement allElement = db.AllElements.Find(id);
            if (allElement == null)
            {
                return HttpNotFound();
            }
            return View(allElement);
        }

        // GET: AllElements/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AllElements/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DSId,DataSetShortName,DSSID,DataSetSectionShortName,DSSEId,DataSetSectionElementShortName,DEID,DataSetName,DataSetNamePersian,DataSetNamePashto,DataSetFor,DataSetSectionName,DataSetNameSectionPersian,DataSetNameSectionPashto,FKDSSDataSetID,DataSetSectionElementName,DataSetNameSectionElementPersian,DataSetNameSectionElementPashto,FKDSSEDataSetSectionID,FKDSSEDataelementID,DataElement,DataElementPersian,DataElementPashto,FKDEDataSetClassficationID,SortOrder,DataElementStatus")] AllElement allElement)
        {
            if (ModelState.IsValid)
            {
                db.AllElements.Add(allElement);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(allElement);
        }

        // GET: AllElements/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AllElement allElement = db.AllElements.Find(id);
            if (allElement == null)
            {
                return HttpNotFound();
            }
            return View(allElement);
        }

        // POST: AllElements/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DSId,DataSetShortName,DSSID,DataSetSectionShortName,DSSEId,DataSetSectionElementShortName,DEID,DataSetName,DataSetNamePersian,DataSetNamePashto,DataSetFor,DataSetSectionName,DataSetNameSectionPersian,DataSetNameSectionPashto,FKDSSDataSetID,DataSetSectionElementName,DataSetNameSectionElementPersian,DataSetNameSectionElementPashto,FKDSSEDataSetSectionID,FKDSSEDataelementID,DataElement,DataElementPersian,DataElementPashto,FKDEDataSetClassficationID,SortOrder,DataElementStatus")] AllElement allElement)
        {
            if (ModelState.IsValid)
            {
                db.Entry(allElement).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(allElement);
        }

        // GET: AllElements/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AllElement allElement = db.AllElements.Find(id);
            if (allElement == null)
            {
                return HttpNotFound();
            }
            return View(allElement);
        }

        // POST: AllElements/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AllElement allElement = db.AllElements.Find(id);
            db.AllElements.Remove(allElement);
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
