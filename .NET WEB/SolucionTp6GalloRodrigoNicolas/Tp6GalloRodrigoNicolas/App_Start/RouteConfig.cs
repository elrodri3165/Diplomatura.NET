using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Tp6GalloRodrigoNicolas
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            routes.MapRoute(
                name: "Usuario",
                url: "Usuario/{nombre}",
                defaults: new { controller = "Usuario", action = "Buscar", nombre = UrlParameter.Optional }
            );
        }
    }
}
