using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Nimap.Models;
using System.Data.Entity;
using System.Web.Routing;

namespace Nimap
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


           routes.MapRoute(
               name: "Create",
               url: "",
               defaults: new { Controller = "DataAccessHome", action = "Create" }
               );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "DataAccessHome", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
