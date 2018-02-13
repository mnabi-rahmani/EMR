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
    public class FacilityGroupMembersController : Controller
    {
        // private WardFormsContext db = new WardFormsContext();
        FacilityGroupMembersRepository GroupMembersRepo = new FacilityGroupMembersRepository();

        // GET: FacilityGroupMembers
        public ActionResult Index()
        {
            var facilityGroupMembers = GroupMembersRepo.GetAllMember();

            return View(facilityGroupMembers.ToList());
            // return View(db.FacilityGroupMembers.ToList());
        }

        // GET: FacilityGroupMembers/Details/5
        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //FacilityGroupMember facilityGroupMember = db.FacilityGroupMembers.Find(id);
            FacilityGroupMember facilityGroupMember = GroupMembersRepo.Get(id);
            if (facilityGroupMember == null)
            {
                return HttpNotFound();
            }
            return View(facilityGroupMember);
        }

        // GET: FacilityGroupMembers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FacilityGroupMembers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FGMID,FKFGMFacilityGroupID,FacilityGroupMemberDescription,FromDate,ThruDate,FKFGMFacilityID")] FacilityGroupMember facilityGroupMember)
        {
            if (ModelState.IsValid)
            {
                // db.FacilityGroupMembers.Add(facilityGroupMember);
                //db.SaveChanges();
                GroupMembersRepo.Add(facilityGroupMember);
                GroupMembersRepo.save();


                return RedirectToAction("Index");
            }

            return View(facilityGroupMember);
        }

        // GET: FacilityGroupMembers/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            // FacilityGroupMember facilityGroupMember = db.FacilityGroupMembers.Find(id);
            FacilityGroupMember facilityGroupMember = GroupMembersRepo.Get(id);
            if (facilityGroupMember == null)
            {
                return HttpNotFound();
            }
            return View(facilityGroupMember);
        }

        // POST: FacilityGroupMembers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FGMID,FKFGMFacilityGroupID,FacilityGroupMemberDescription,FromDate,ThruDate,FKFGMFacilityID")] FacilityGroupMember facilityGroupMember)
        {
            if (ModelState.IsValid)
            {
                //  db.Entry(facilityGroupMember).State = EntityState.Modified;
                // db.SaveChanges();
                GroupMembersRepo.UpdateGroupMember(facilityGroupMember);
                return RedirectToAction("Index");
              
            }
            return View(facilityGroupMember);
        }

        // GET: FacilityGroupMembers/Delete/5
        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            // FacilityGroupMember facilityGroupMember = db.FacilityGroupMembers.Find(id);
            FacilityGroupMember facilityGroupMember = GroupMembersRepo.Get(id);
            if (facilityGroupMember == null)
            {
                return HttpNotFound();
            }
            return View(facilityGroupMember);
        }

        // POST: FacilityGroupMembers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            //FacilityGroupMember facilityGroupMember = db.FacilityGroupMembers.Find(id);
            //db.FacilityGroupMembers.Remove(facilityGroupMember);
            //db.SaveChanges();
            FacilityGroupMember facilityGroupMember = GroupMembersRepo.Get(id);
            GroupMembersRepo.Remove(facilityGroupMember);
            GroupMembersRepo.save();
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
