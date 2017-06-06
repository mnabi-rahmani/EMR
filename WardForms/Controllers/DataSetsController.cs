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
    public class DataSetsController : Controller
    {
        private WardFormsCoreDataModel db = new WardFormsCoreDataModel();

        // GET: DataSets
        public ActionResult Index()
        {
            return View(db.DataSetTbls.ToList());
        }

        // GET: DataSets/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DataSetTbl dataSetTbl = db.DataSetTbls.Find(id);
            if (dataSetTbl == null)
            {
                return HttpNotFound();
            }
            return View(dataSetTbl);
        }

        // GET: DataSets/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DataSets/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DSId,DataSetShortName,DataSetName,DataSetNamePersian,DataSetNamePashto,DataSetFor")] DataSetTbl dataSetTbl)
        {
            if (ModelState.IsValid)
            {
                db.DataSetTbls.Add(dataSetTbl);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dataSetTbl);
        }

        // GET: DataSets/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DataSetTbl dataSetTbl = db.DataSetTbls.Find(id);
            if (dataSetTbl == null)
            {
                return HttpNotFound();
            }
            return View(dataSetTbl);
        }

        // POST: DataSets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DSId,DataSetShortName,DataSetName,DataSetNamePersian,DataSetNamePashto,DataSetFor")] DataSetTbl dataSetTbl)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dataSetTbl).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dataSetTbl);
        }

        // GET: DataSets/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DataSetTbl dataSetTbl = db.DataSetTbls.Find(id);
            if (dataSetTbl == null)
            {
                return HttpNotFound();
            }
            return View(dataSetTbl);
        }

        // POST: DataSets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DataSetTbl dataSetTbl = db.DataSetTbls.Find(id);
            db.DataSetTbls.Remove(dataSetTbl);
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
