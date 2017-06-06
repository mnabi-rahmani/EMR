using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
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
    }
}