using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UI.Models;

namespace UI.Controllers
{
    public class ComprasController : Controller
    {
        // GET: Compras
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Buscar(int numero)
        {
            DAL buscar = new DAL();
            
            List<Compra> compras = new List<Compra>();

            compras = buscar.ListarUsuarios(numero);
            
            return View(compras);
        }
    }
}
