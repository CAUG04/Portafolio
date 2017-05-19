using Helper;
using Model;
using Portafolio.Areas.Admin.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Portafolio.Areas.Admin.Controllers
{
    [Autenticado]
    public class UsuarioController : Controller
    {
        private Usuario usuario = new Usuario();
        private TablaDato dato = new TablaDato();

        // GET: Admin/Usuario
        public ActionResult Index()
        {
            ViewBag.Paises = dato.Listar("pais");
            return View(usuario.Obtener(SessionHelper.GetUser()));
        }
    }
}