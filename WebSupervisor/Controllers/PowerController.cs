﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebSupervisor.Controllers
{
    public class PowerController : Controller
    {
        // GET: Power
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult PowerManger()
        {
            return View();
        }
    }
}