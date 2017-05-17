﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;
using Helper;
using Portafolio.Areas.Admin.Filters;

namespace Portafolio.Areas.Admin.Controllers
{
    [NoLogin]
    public class LoginController : Controller
    {
        private Usuario usuario = new Usuario();


        // GET: Admin/Login
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult Acceder(string Email, string Password)
        {
            var rm = usuario.Acceder(Email, Password);

            if(rm.response)
            {
                rm.href = Url.Content("~/admin/usuario");
            }
            return Json(rm);
        }

        public ActionResult Logout()
        {
            // Eliminar la sesion actual
            SessionHelper.DestroyUserSession();
            return Redirect("~/");
        }
    }
}