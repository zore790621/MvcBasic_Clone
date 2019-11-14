﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MvcBasic_Clone
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "iPadRoute",
                url: "iPad",
                defaults: new { controller = "iPad", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "iPhoneRoute",
                url: "iPhone",
                defaults: new { controller = "iPhone", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "MacRoute",
                url: "Mac",
                defaults: new { controller = "Mac", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "WatchRoute",
                url: "Watch",
                defaults: new { controller = "Watch", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
