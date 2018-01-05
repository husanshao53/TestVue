﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestVue.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Vue01()
        {
            return View();
        }

        public ActionResult Vue02()
        {
            return View();
        }
        public ActionResult jsTest()
        {
            return View();
        }

        public ActionResult ShoppingCart()
        {
            return View();
        }
    }
}