﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleFood.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Catalog()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }
        
        public ActionResult Product()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }
        
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }
    }
}