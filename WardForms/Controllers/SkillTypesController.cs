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
    public class SkillTypesController : Controller
    {
        private WardFormsCoreDataModel db = new WardFormsCoreDataModel();

        // GET: SkillTypes
        public ActionResult Index()
        {
            return View(db.SkillTypes.ToList());
        }

        // GET: SkillTypes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SkillType skillType = db.SkillTypes.Find(id);
            if (skillType == null)
            {
                return HttpNotFound();
            }
            return View(skillType);
        }

        // GET: SkillTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SkillTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SkillTypeID,SkillDescription,SkillDescriptionLocal")] SkillType skillType)
        {
            if (ModelState.IsValid)
            {
                db.SkillTypes.Add(skillType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(skillType);
        }

        // GET: SkillTypes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SkillType skillType = db.SkillTypes.Find(id);
            if (skillType == null)
            {
                return HttpNotFound();
            }
            return View(skillType);
        }

        // POST: SkillTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SkillTypeID,SkillDescription,SkillDescriptionLocal")] SkillType skillType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(skillType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(skillType);
        }

        // GET: SkillTypes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SkillType skillType = db.SkillTypes.Find(id);
            if (skillType == null)
            {
                return HttpNotFound();
            }
            return View(skillType);
        }

        // POST: SkillTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SkillType skillType = db.SkillTypes.Find(id);
            db.SkillTypes.Remove(skillType);
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
