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
    
    public class EmployeesController : Controller
    {
        // static  ApplicationDbContext db = new ApplicationDbContext();
        EmployeesRepository EmployeeRepo = new EmployeesRepository();
        EmployeeViewModel employeeViewModel = new EmployeeViewModel();


        //GET: Employees
        public ActionResult Index()
        {

            return View(EmployeeRepo.GetAllEmployees());
        }

        // GET: Employees/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            employeeViewModel =  EmployeeRepo.GetEmployee(id);

            if (employeeViewModel == null)
            {
                return HttpNotFound();
            }
            return View(employeeViewModel);
        }

        // GET: Employees/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employees/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PersonID,EmployeeID,EmployeeType,FirstName,MiddleName,LastName,FatherName,Gender,MaritalStatus,DateOfBirth,BloodGroup,TazkiraNumber,PassportNumber")] EmployeeViewModel employeeViewModel)
        {
            if (ModelState.IsValid)
            {
                EmployeeRepo.AddEmployee(employeeViewModel);


           
                return RedirectToAction("Index");
            }

            return View(employeeViewModel);
        }

        // GET: Employees/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            employeeViewModel = EmployeeRepo.GetEmployee(id);
            if (employeeViewModel == null)
            {
                return HttpNotFound();
            }
            return View(employeeViewModel);
        }

        // POST: Employees/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PersonID,EmployeeID,EmployeeType,FirstName,MiddleName,LastName,FatherName,Gender,MaritalStatus,DateOfBirth,BloodGroup,TazkiraNumber,PassportNumber")] EmployeeViewModel employeeViewModel)
        {
            if (ModelState.IsValid)
            {

                EmployeeRepo.UpdateEmployee(employeeViewModel);

              //  db.Entry(employeeViewModel).State = EntityState.Modified;
              //  db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employeeViewModel);
        }

        // GET: Employees/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //    EmployeeViewModel employeeViewModel = db.EmployeeViewModels.Find(id);

            employeeViewModel =  EmployeeRepo.GetEmployee(id);
            if (employeeViewModel == null)
            {
                return HttpNotFound();
            }
            return View(employeeViewModel);
        }

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            // EmployeeViewModel employeeViewModel = db.EmployeeViewModels.Find(id);
            EmployeeRepo.RemoveEmployee(id);
           // db.EmployeeViewModels.Remove(employeeViewModel);
           // db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
         //   if (disposing)
          //  {
                //db.Dispose();
         //   }
           // base.Dispose(disposing);
        }
    }
}
