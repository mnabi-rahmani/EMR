using System;
using System.Collections.Generic;
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