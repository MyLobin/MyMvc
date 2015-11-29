using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MyMvc.App_Start
{
    public class RouteConfig
    {
        public static void RegistRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("");
            routes.MapRoute(
                name: "default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "home", action = "index", id = UrlParameter.Optional }
                );

        }
    }
}