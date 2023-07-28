using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tp6GalloRodrigoNicolas.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Index()
        {
            return View();
        }

        // GET: Usuario
        public ActionResult Buscar(string nombre)
        {
            var input = Server.HtmlEncode(nombre);
            input = "<h1>" + input + "<h1>";
            return Content(input);
        }









    }
}
