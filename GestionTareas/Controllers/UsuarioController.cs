using GestionTareas.Dato;
using GestionTareas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GestionTareas.Controllers
{
    public class UsuarioController : Controller
    {
        UsuarioAdmin admin = new UsuarioAdmin();

        // GET: Usuario
        public ActionResult Index()
        {
            IEnumerable<usuarios> lista = admin.Consultar();
            return View(lista);
        }
    }
}