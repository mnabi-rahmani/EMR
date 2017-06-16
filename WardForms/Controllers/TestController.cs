using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WardFormsCore.DataModel;
using WardFormsCore.Repository;
namespace WardForms.Controllers
{
    public class TestController : Controller
    {
        UnitOfWork UnitOfWork = new UnitOfWork(new WardFormsCoreDataModel());
        // GET: Test
        public ActionResult Index()
        {
        
         return View(   UnitOfWork.DataSetUIconfigs.getallelements());


        //    return View(r.getmodel().AllElements.ToList());
        //    return View();
        }

        [HttpPost]

    
        public void uiconfig(string data_row, string data_col, string data_sizex, string data_sizey, string name)
        {
          
            UnitOfWork.DataSetUIconfigs.AddorUpdateExisting( data_row,  data_col,  data_sizex,  data_sizey,  name);
            UnitOfWork.Complete();
        }








    

       


        public ActionResult Create( AllElement AllElement)
        {
           UnitOfWork unitOfWork = new UnitOfWork(new WardFormsCoreDataModel());


            //db.getmodel().ElementValues.Add();
         
            string sss = "";
            foreach (string s in Request.Form.Keys)
            {
                //if (s.Substring(1, 1) != "_")
                {
                    int a=0;

                    int.TryParse(s,out a);
                    if (a != 0)
                    {
                   //     WardFormsCoreDataModel dbb = new WardFormsCoreDataModel();


                        
                        ElementValue ev= new ElementValue();

                        ev.DataElementValue = Request.Form[s];
                        ev.FKEVDataElementID = a;// int.Parse(Request.Form[s]);
                      //  dbb.ElementValues.Add(ev);
                       // dbb.SaveChanges();
                       unitOfWork.Elements.Add(ev);
                       unitOfWork.Complete();
                    }
                  
                }

            }

         Response.Redirect("/test/index");
            return View();
        }

    }
}