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
    public class PersonRolesController : Controller
    {
        private WardFormsCoreDataModel db = new WardFormsCoreDataModel();

        // GET: PersonRoles
        public ActionResult Index()
        {
            var personRoles = db.PersonRoles.Include(p => p.Employee).Include(p => p.Patient).Include(p => p.Person).Include(p => p.RoleType).Include(p => p.User);
            return View(personRoles.ToList());
        }

        // GET: PersonRoles/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PersonRole personRole = db.PersonRoles.Find(id);
            if (personRole == null)
            {
                return HttpNotFound();
            }
            return View(personRole);
        }

        // GET: PersonRoles/Create
        public ActionResult Create()
        {
            ViewBag.PersonRoleID = new SelectList(db.Employees, "PersonRoleID", "PersonRoleID");
            ViewBag.PersonRoleID = new SelectList(db.Patients, "PersonRoleID", "PersonRoleID");
            ViewBag.PartyID = new SelectList(db.People, "PartyID", "Name");
            ViewBag.RoleTypeId = new SelectList(db.RoleTypes, "RoleTypeId", "RoleType1");
            ViewBag.PersonRoleID = new SelectList(db.Users, "PersonRoleID", "PersonRoleID");
            return View();
        }

        // POST: PersonRoles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PersonRoleID,StartDate,ThruDate,PartyID,RoleTypeId")] PersonRole personRole)
        {
            if (ModelState.IsValid)
            {
                db.PersonRoles.Add(personRole);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.PersonRoleID = new SelectList(db.Employees, "PersonRoleID", "PersonRoleID", personRole.PersonRoleID);
            ViewBag.PersonRoleID = new SelectList(db.Patients, "PersonRoleID", "PersonRoleID", personRole.PersonRoleID);
            ViewBag.PartyID = new SelectList(db.People, "PartyID", "Name", personRole.PartyID);
            ViewBag.RoleTypeId = new SelectList(db.RoleTypes, "RoleTypeId", "RoleType1", personRole.RoleTypeId);
            ViewBag.PersonRoleID = new SelectList(db.Users, "PersonRoleID", "PersonRoleID", personRole.PersonRoleID);
            return View(personRole);
        }

        // GET: PersonRoles/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PersonRole personRole = db.PersonRoles.Find(id);
            if (personRole == null)
            {
                return HttpNotFound();
            }
            ViewBag.PersonRoleID = new SelectList(db.Employees, "PersonRoleID", "PersonRoleID", personRole.PersonRoleID);
            ViewBag.PersonRoleID = new SelectList(db.Patients, "PersonRoleID", "PersonRoleID", personRole.PersonRoleID);
            ViewBag.PartyID = new SelectList(db.People, "PartyID", "Name", personRole.PartyID);
            ViewBag.RoleTypeId = new SelectList(db.RoleTypes, "RoleTypeId", "RoleType1", personRole.RoleTypeId);
            ViewBag.PersonRoleID = new SelectList(db.Users, "PersonRoleID", "PersonRoleID", personRole.PersonRoleID);
            return View(personRole);
        }

        // POST: PersonRoles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PersonRoleID,StartDate,ThruDate,PartyID,RoleTypeId")] PersonRole personRole)
        {
            if (ModelState.IsValid)
            {
                db.Entry(personRole).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PersonRoleID = new SelectList(db.Employees, "PersonRoleID", "PersonRoleID", personRole.PersonRoleID);
            ViewBag.PersonRoleID = new SelectList(db.Patients, "PersonRoleID", "PersonRoleID", personRole.PersonRoleID);
            ViewBag.PartyID = new SelectList(db.People, "PartyID", "Name", personRole.PartyID);
            ViewBag.RoleTypeId = new SelectList(db.RoleTypes, "RoleTypeId", "RoleType1", personRole.RoleTypeId);
            ViewBag.PersonRoleID = new SelectList(db.Users, "PersonRoleID", "PersonRoleID", personRole.PersonRoleID);
            return View(personRole);
        }

        // GET: PersonRoles/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PersonRole personRole = db.PersonRoles.Find(id);
            if (personRole == null)
            {
                return HttpNotFound();
            }
            return View(personRole);
        }

        // POST: PersonRoles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PersonRole personRole = db.PersonRoles.Find(id);
            db.PersonRoles.Remove(personRole);
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
