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
    public class DataSetSectionsController : Controller
    {
        private WardFormsCoreDataModel db = new WardFormsCoreDataModel();

        // GET: DataSetSections
        public ActionResult Index()
        {
            var dataSetSections = db.DataSetSections.Include(d => d.DataSetTbl);
            return View(dataSetSections.ToList());
        }

        // GET: DataSetSections/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DataSetSection dataSetSection = db.DataSetSections.Find(id);
            if (dataSetSection == null)
            {
                return HttpNotFound();
            }
            return View(dataSetSection);
        }

        // GET: DataSetSections/Create
        public ActionResult Create()
        {
            ViewBag.FKDSSDataSetID = new SelectList(db.DataSetTbls, "DSId", "DataSetShortName");
            return View();
        }

        // POST: DataSetSections/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DSSID,DataSetSectionShortName,DataSetSectionName,DataSetNameSectionPersian,DataSetNameSectionPashto,FKDSSDataSetID")] DataSetSection dataSetSection)
        {
            if (ModelState.IsValid)
            {
                db.DataSetSections.Add(dataSetSection);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.FKDSSDataSetID = new SelectList(db.DataSetTbls, "DSId", "DataSetShortName", dataSetSection.FKDSSDataSetID);
            return View(dataSetSection);
        }

        // GET: DataSetSections/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DataSetSection dataSetSection = db.DataSetSections.Find(id);
            if (dataSetSection == null)
            {
                return HttpNotFound();
            }
            ViewBag.FKDSSDataSetID = new SelectList(db.DataSetTbls, "DSId", "DataSetShortName", dataSetSection.FKDSSDataSetID);
            return View(dataSetSection);
        }

        // POST: DataSetSections/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DSSID,DataSetSectionShortName,DataSetSectionName,DataSetNameSectionPersian,DataSetNameSectionPashto,FKDSSDataSetID")] DataSetSection dataSetSection)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dataSetSection).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.FKDSSDataSetID = new SelectList(db.DataSetTbls, "DSId", "DataSetShortName", dataSetSection.FKDSSDataSetID);
            return View(dataSetSection);
        }

        // GET: DataSetSections/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DataSetSection dataSetSection = db.DataSetSections.Find(id);
            if (dataSetSection == null)
            {
                return HttpNotFound();
            }
            return View(dataSetSection);
        }

        // POST: DataSetSections/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DataSetSection dataSetSection = db.DataSetSections.Find(id);
            db.DataSetSections.Remove(dataSetSection);
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
