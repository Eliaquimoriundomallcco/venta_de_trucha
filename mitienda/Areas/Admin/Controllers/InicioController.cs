﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mitienda.Areas.Admin.Controllers
{
    public class InicioController : Controller
    {
        // GET: Admin/Inicio
        public ActionResult Index()
        {
            return View();
        }
    }
}