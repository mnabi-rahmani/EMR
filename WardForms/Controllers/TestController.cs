using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WardFormsCore.Data;
using WardFormsCore.Repository;
namespace WardForms.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            Repository r= new Repository();

           
            return View(r.getmodel().AllElements.ToList());
        }

        [HttpPost]


        public void uiconfig(string data_row, string data_col, string data_sizex, string data_sizey, string name)
        {
            WardFormsCoreDataModel dbb = new WardFormsCoreDataModel();

            int id = Convert.ToInt32(name);


            DataSetUIconfig dsui = new DataSetUIconfig();

            List<DataSetUIconfig> dsuilist = (from a in dbb.datasetUIconfig
                where a.DSSEId == id
                select a).ToList();

            if (dsuilist.Count() == 0)
            {
                dsui.data_row = Convert.ToInt32(data_row);
                dsui.data_col = Convert.ToInt32(data_col);
                dsui.data_sizex = Convert.ToInt32(data_sizex);
                dsui.data_sizey = Convert.ToInt32(data_sizey);
                dsui.DSSEId = Convert.ToInt32(name);


                dbb.datasetUIconfig.Add(dsui);
                dbb.SaveChanges();

            }
            else
            {
                foreach (var d in dsuilist)
                {
                    dsui.data_row = Convert.ToInt32(data_row);
                    dsui.data_col = Convert.ToInt32(data_col);
                    dsui.data_sizex = Convert.ToInt32(data_sizex);
                    dsui.data_sizey = Convert.ToInt32(data_sizey);
                    dsui.DSSEId = Convert.ToInt32(name);
                    dsui.DSUIID = d.DSUIID;

                    dbb.datasetUIconfig.AddOrUpdate(dsui);
                    dbb.SaveChanges();
                }








            }
        }

        public ActionResult Create( AllElement AllElement)
        {
            Repository db= new Repository();

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
                        WardFormsCoreDataModel dbb = new WardFormsCoreDataModel();


                        
                        ElementValue ev= new ElementValue();

                        ev.DataElementValue = Request.Form[s];
                        ev.FKEVDataElementID = a;// int.Parse(Request.Form[s]);
                        dbb.ElementValues.Add(ev);
                        dbb.SaveChanges();
                    }
                  
                }

            }

         Response.Redirect("/test/index");
            return View();
        }

    }
}