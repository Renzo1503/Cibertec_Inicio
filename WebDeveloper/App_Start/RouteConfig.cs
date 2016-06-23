using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebDeveloper
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            //Si no se muestra la linea siguiente no podrian usar las extensiones.
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Razor",
                url: "Razor/{id}",
                defaults: new
                {
                    controller = "Razor",
                    action = "Product",
                    id = UrlParameter.Optional
                }
            );

            /*
            1.El nombre no se puede repetir.
            2.Todos los mapeos que se deban crear deben estar anter del Default.
            */
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new
                {
                    controller = "Home",
                    action = "Index",
                    id = UrlParameter.Optional
                }
            );
        }
    }
}
