using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC_Fund6_2
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "MVC_Fund6_2.Controllers"}
            );
            routes.MapRoute(
                name: "PublicRoute",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Orders", action = "Report", y=0 },
                namespaces: new[] { "MVC_Fund6_2.Controllers" }
            );
            routes.MapRoute(
                 name: "PublicRoute2",
                 url: "{controller}/{action}/{id}",
                 defaults: new { controller = "Orders", action = "Report", id = UrlParameter.Optional },
                 namespaces: new[] { "MVC_Fund6_2.Controllers" }
);
        }
    }
}
