using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace VCDVibez
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapMvcAttributeRoutes();
            // custom routing (Traditional routing)
            //routes.MapRoute(
            //    "MoviesByReleaseDate",
            //    "movies/released/{year}/{Month}",
            //    new { Controller="Movies",Action="ByReleaseDate"},
            //    new { year=@"\d{4}",Month=@"\d{2}"},
            //   // new { year = "2015|2016" }
            //    );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
