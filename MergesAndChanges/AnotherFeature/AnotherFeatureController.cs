using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MergesAndChanges.Controllers
{
    public class AnotherFeatureController : Controller
    {
        //
        // GET: /AnotherFeature/
        public ActionResult Index()
        {
            var someAdditionalVar = "Test";
            var anotherVariable = 2;
            return View();
        }

        public ActionResult ChangesInChangeContentBranch()
        {
            
            return View();
        }
	}
}