﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MergesAndChanges.Controllers
{
    public class FeatureController : Controller
    {
        //
        // GET: /Feature/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AdditionalChangeWhenMoving()
        {
            return View();
        }
        public ActionResult ChangesOnController()
        {
            return View();
        }
	}
}