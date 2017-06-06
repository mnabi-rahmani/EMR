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
            string sss = "";
            foreach (string s in Request.Form.Keys)


            {

                sss += s.ToString() + ":" + Request.Form[s] + " ";


            }

            //foreach (string key in Request.Form)
            //{
            //    if (!key.StartsWith("checkbox"))
            //    {}

            //}
            return View(AllElement);
        }

    }
}