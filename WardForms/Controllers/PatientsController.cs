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
    public class PatientsController : Controller
    {
        PatientsRepository PatientRepo = new PatientsRepository();
        PatientViewModel patientViewModel = new PatientViewModel();


        // GET: Patients
        public ActionResult Index()
        {
            return View(PatientRepo.GetAllPatients());
        }

        // GET: Patients/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            patientViewModel = PatientRepo.GetPatient(id);
            if (patientViewModel == null)
            {
                return HttpNotFound();
            }
            return View(patientViewModel);
        }

        // GET: Patients/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Patients/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PersonID,PatientID,PatientType,FirstName,MiddleName,LastName,FatherName,Gender,MaritalStatus,DateOfBirth,BloodGroup,TazkiraNumber,PassportNumber")] PatientViewModel patientViewModel)
        {
            if (ModelState.IsValid)
            {
                PatientRepo.AddPatient(patientViewModel);


                return RedirectToAction("Index");
            }

            return View(patientViewModel);
        }

        // GET: Patients/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            patientViewModel =PatientRepo.GetPatient(id);
            if (patientViewModel == null)
            {
                return HttpNotFound();
            }
            return View(patientViewModel);
        }

        // POST: Patients/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PersonID,PatientID,PatientType,FirstName,MiddleName,LastName,FatherName,Gender,MaritalStatus,DateOfBirth,BloodGroup,TazkiraNumber,PassportNumber")] PatientViewModel patientViewModel)
        {
            if (ModelState.IsValid)
            {
                PatientRepo.UpdatePatient(patientViewModel);

                return RedirectToAction("Index");
            }
            return View(patientViewModel);
        }

        // GET: Patients/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            patientViewModel = PatientRepo.GetPatient(id);
            if (patientViewModel == null)
            {
                return HttpNotFound();
            }
            return View(patientViewModel);
        }

        // POST: Patients/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            //PatientViewModel patientViewModel = db.PatientViewModels.Find(id);
            //db.PatientViewModels.Remove(patientViewModel);
            //db.SaveChanges();
            PatientRepo.RemovePatient(id);

            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
           
        }
    }
}
