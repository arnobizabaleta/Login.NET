﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PRUEBAS_LOGIN.Permisos;

namespace PRUEBAS_LOGIN.Controllers
{
    /*
     Antes que se ejecute cualquier método del controlador principal
    Se ejecuta la logica de la clase ValidarSessionAttributte
     */
    [ValidarSessionAttributte]
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

        public ActionResult CerrarSesion()
        {
            Session["usuario"] = null;//Empting Session User
            return RedirectToAction("Login", "Acceso");// Redirect to Login
        }

        
    }
}