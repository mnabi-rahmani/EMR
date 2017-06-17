using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WardFormsCore.DataModel;
using WardFormsCore.Repository;

namespace WardForms.Controllers
{
 
    public class ServicesController : Controller
    {
        UnitOfWork UnitOfWork = new UnitOfWork(new WardFormsCoreDataModel());

        private WardFormsCoreDataModel db = new WardFormsCoreDataModel();

        // GET: Services
        public ActionResult Index()
        {
            var services = db.Services.Include(s => s.DataSetTbl).Include(s => s.Facility).Include(s => s.PatientVisit).Include(s => s.PurposeType);
            return View(services.ToList());
        }

        // GET: Services/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Service service = db.Services.Find(id);
            if (service == null)
            {
                return HttpNotFound();
            }
            return View(service);
        }

        // GET: Services/Details/5
        public ActionResult servicedetail(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Service service = db.Services.Find(id);
            if (service == null)
            {
                return HttpNotFound();
            }
            @ViewBag.service = service.ServiceID;

            return View(UnitOfWork.DataSetUIconfigs.getallelementsfor(service.Purpose));
           

          //  return View(service);
        }

        public void uiconfig(string data_row, string data_col, string data_sizex, string data_sizey, string name)
        {

            UnitOfWork.DataSetUIconfigs.AddorUpdateExisting(data_row, data_col, data_sizex, data_sizey, name);
            UnitOfWork.Complete();
        }

        public ActionResult Createservice(string service)
        {
            UnitOfWork unitOfWork = new UnitOfWork(new WardFormsCoreDataModel());


            //db.getmodel().ElementValues.Add();

            string sss = "";
            foreach (string s in Request.Form.Keys)
            {
                //if (s.Substring(1, 1) != "_")
                {
                    int a = 0;

                    int.TryParse(s, out a);
                    if (a != 0)
                    {
                        //     WardFormsCoreDataModel dbb = new WardFormsCoreDataModel();



                        ElementValue ev = new ElementValue();

                        ev.DataElementValue = Request.Form[s];
                        ev.FKEVDataElementID = a;
                        ev.ServiceID =Convert.ToInt32(service);
                        // int.Parse(Request.Form[s]);
                        //  dbb.ElementValues.Add(ev);
                        // dbb.SaveChanges();
                        unitOfWork.Elements.Add(ev);
                        unitOfWork.Complete();
                    }

                }

            }

            Response.Redirect("/Services/index");
            return View();
        }

        // GET: Services/Create
        public ActionResult Create()
        {
            ViewBag.FKSWardID = new SelectList(db.DataSetTbls, "DSId", "DataSetShortName");
            ViewBag.FKSFacillityID = new SelectList(db.Facilities, "FID", "FacilityName");
            ViewBag.VisitID = new SelectList(db.PatientVisits, "VisitID", "VisitID");
            ViewBag.Purpose = new SelectList(db.PurposeTypes, "PurposeID", "Purpose");
            return View();
        }

        // POST: Services/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ServiceID,FKSFacillityID,FKSWardID,VisitID,StartDate,EndDate,Purpose")] Service service)
        {
            if (ModelState.IsValid)
            {
                db.Services.Add(service);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.FKSWardID = new SelectList(db.DataSetTbls, "DSId", "DataSetShortName", service.FKSWardID);
            ViewBag.FKSFacillityID = new SelectList(db.Facilities, "FID", "FacilityName", service.FKSFacillityID);
            ViewBag.VisitID = new SelectList(db.PatientVisits, "VisitID", "VisitID", service.VisitID);
            ViewBag.Purpose = new SelectList(db.PurposeTypes, "PurposeID", "Purpose", service.Purpose);
            return View(service);
        }

        // GET: Services/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Service service = db.Services.Find(id);
            if (service == null)
            {
                return HttpNotFound();
            }
            ViewBag.FKSWardID = new SelectList(db.DataSetTbls, "DSId", "DataSetShortName", service.FKSWardID);
            ViewBag.FKSFacillityID = new SelectList(db.Facilities, "FID", "FacilityName", service.FKSFacillityID);
            ViewBag.VisitID = new SelectList(db.PatientVisits, "VisitID", "VisitID", service.VisitID);
            ViewBag.Purpose = new SelectList(db.PurposeTypes, "PurposeID", "Purpose", service.Purpose);
            return View(service);
        }

        // POST: Services/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ServiceID,FKSFacillityID,FKSWardID,VisitID,StartDate,EndDate,Purpose")] Service service)
        {
            if (ModelState.IsValid)
            {
                db.Entry(service).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.FKSWardID = new SelectList(db.DataSetTbls, "DSId", "DataSetShortName", service.FKSWardID);
            ViewBag.FKSFacillityID = new SelectList(db.Facilities, "FID", "FacilityName", service.FKSFacillityID);
            ViewBag.VisitID = new SelectList(db.PatientVisits, "VisitID", "VisitID", service.VisitID);
            ViewBag.Purpose = new SelectList(db.PurposeTypes, "PurposeID", "Purpose", service.Purpose);
            return View(service);
        }

        // GET: Services/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Service service = db.Services.Find(id);
            if (service == null)
            {
                return HttpNotFound();
            }
            return View(service);
        }

        // POST: Services/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Service service = db.Services.Find(id);
            db.Services.Remove(service);
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
