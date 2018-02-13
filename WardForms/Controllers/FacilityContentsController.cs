using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WardForms.Models;
using WardForms.Repository;

namespace WardForms.Controllers
{
    public class FacilityContentsController : Controller
    {
        // private WardFormsContext db = new WardFormsContext();
        FacilityContentsRepository ContentsRepo = new FacilityContentsRepository();

        // GET: FacilityContents
        public ActionResult Index()
        {
            //return View(db.FacilityContents.ToList());
            var contents = ContentsRepo.GetAllContents();

            return View(contents.ToList());
        }

        // GET: FacilityContents/Details/5
        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            // FacilityContent facilityContent = db.FacilityContents.Find(id);
            FacilityContent facilityContent = ContentsRepo.Get(id);
            if (facilityContent == null)
            {
                return HttpNotFound();
            }
            return View(facilityContent);
        }

        // GET: FacilityContents/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FacilityContents/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FCID,FacilityContent1,StartDate,ThruDate,FKFCFacilityID")] FacilityContent facilityContent)
        {
            if (ModelState.IsValid)
            {
                //db.FacilityContents.Add(facilityContent);
                //db.SaveChanges();
                ContentsRepo.Add(facilityContent);
                ContentsRepo.save();
                return RedirectToAction("Index");
            }

            return View(facilityContent);
        }

        // GET: FacilityContents/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            // FacilityContent facilityContent = db.FacilityContents.Find(id);
            FacilityContent facilityContent = ContentsRepo.Get(id);
            if (facilityContent == null)
            {
                return HttpNotFound();
            }
            return View(facilityContent);
        }

        // POST: FacilityContents/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FCID,FacilityContent1,StartDate,ThruDate,FKFCFacilityID")] FacilityContent facilityContent)
        {
            if (ModelState.IsValid)
            {
                // db.Entry(facilityContent).State = EntityState.Modified;
                //db.SaveChanges();
                ContentsRepo.UpdateContent(facilityContent);
                return RedirectToAction("Index");
            }
            return View(facilityContent);
        }

        // GET: FacilityContents/Delete/5
        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            // FacilityContent facilityContent = db.FacilityContents.Find(id);
            FacilityContent facilityContent = ContentsRepo.Get(id);
            if (facilityContent == null)
            {
                return HttpNotFound();
            }
            return View(facilityContent);
        }

        // POST: FacilityContents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            // FacilityContent facilityContent = db.FacilityContents.Find(id);
            //db.FacilityContents.Remove(facilityContent);
            // db.SaveChanges();
            FacilityContent facilityContent = ContentsRepo.Get(id);
            ContentsRepo.Remove(facilityContent);
            ContentsRepo.save();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            //if (disposing)
            //{
            //    db.Dispose();
            //}
            //base.Dispose(disposing);
        }
    }
}
