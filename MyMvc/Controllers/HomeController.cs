﻿using MyMvc.Proxy;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMvc.Controllers
{
    public class HomeController:Controller
    {
        public ActionResult Index()
        {
            var proxy = ModelProxy.CreateService();
            var model = proxy.GetEmployeeList().FirstOrDefault();
            return View(model);
        }
        public ActionResult Test()
        {
            int b = 0;
            int a = 1 / b;
            Trace.TraceError("aaa");
            return Content("test");
        }
    }
}