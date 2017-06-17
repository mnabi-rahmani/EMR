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
    public class PartiesController : Controller
    {
        private WardFormsCoreDataModel db = new WardFormsCoreDataModel();

        // GET: Parties
        public ActionResult Index()
        {
            var parties = db.Parties.Include(p => p.Organization).Include(p => p.PartyType).Include(p => p.Person);
            return View(parties.ToList());
        }

        // GET: Parties/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Party party = db.Parties.Find(id);
            if (party == null)
            {
                return HttpNotFound();
            }
            return View(party);
        }

        // GET: Parties/Create
        public ActionResult Create()
        {
            ViewBag.PartyID = new SelectList(db.Organizations, "PartyID", "Name");
            ViewBag.PartyTypeID = new SelectList(db.PartyTypes, "PartyTypeID", "PartyType1");
            ViewBag.PartyID = new SelectList(db.People, "PartyID", "Name");
            return View();
        }

        // POST: Parties/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PartyID,StartDate,ThruDate,PartyTypeID")] Party party)
        {
            if (ModelState.IsValid)
            {
                db.Parties.Add(party);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.PartyID = new SelectList(db.Organizations, "PartyID", "Name", party.PartyID);
            ViewBag.PartyTypeID = new SelectList(db.PartyTypes, "PartyTypeID", "PartyType1", party.PartyTypeID);
            ViewBag.PartyID = new SelectList(db.People, "PartyID", "Name", party.PartyID);
            return View(party);
        }

        // GET: Parties/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Party party = db.Parties.Find(id);
            if (party == null)
            {
                return HttpNotFound();
            }
            ViewBag.PartyID = new SelectList(db.Organizations, "PartyID", "Name", party.PartyID);
            ViewBag.PartyTypeID = new SelectList(db.PartyTypes, "PartyTypeID", "PartyType1", party.PartyTypeID);
            ViewBag.PartyID = new SelectList(db.People, "PartyID", "Name", party.PartyID);
            return View(party);
        }

        // POST: Parties/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PartyID,StartDate,ThruDate,PartyTypeID")] Party party)
        {
            if (ModelState.IsValid)
            {
                db.Entry(party).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PartyID = new SelectList(db.Organizations, "PartyID", "Name", party.PartyID);
            ViewBag.PartyTypeID = new SelectList(db.PartyTypes, "PartyTypeID", "PartyType1", party.PartyTypeID);
            ViewBag.PartyID = new SelectList(db.People, "PartyID", "Name", party.PartyID);
            return View(party);
        }

        // GET: Parties/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Party party = db.Parties.Find(id);
            if (party == null)
            {
                return HttpNotFound();
            }
            return View(party);
        }

        // POST: Parties/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Party party = db.Parties.Find(id);
            db.Parties.Remove(party);
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
