using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC_Fund2
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
             name: "Arifm",
             url: "{controller}/{action}/{x}/{y}",
              defaults: new { controller = "Calc", action = "Add", x = 0, y = 0 },
              namespaces: new[] { "MVC_Fund2.Controllers" }
                );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "MVC_Fund2.Controllers" }
            );

        }

    }
}
