using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace tp3_bd
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}",
                defaults: new { controller = "Home", action = "index" },
               constraints: new {action = @"[a-zA-Z]+" }
            );
            routes.MapRoute(
                 name: "OTher",
                url: "Person/{id}",
                defaults: new { controller = "Person", action = "id" },
                constraints: new { id = @"\d+" }
            );

        }
    }
}
