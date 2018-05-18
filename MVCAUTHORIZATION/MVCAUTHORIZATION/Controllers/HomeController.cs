﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAUTHORIZATION.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        // GET: Home
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult TestAction() {

            return View();
        }
    }
}