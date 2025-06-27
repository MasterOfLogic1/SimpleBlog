using SimpleBlog.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SimpleBlog
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            var namespaces = new [] {typeof(PostsController).Namespace};

            routes.MapRoute(
                name: "Home",
                url: "",
                defaults: new { controller = "Posts", action = "Index" },
                namespaces
            );

            routes.MapRoute(
                name: "Login",
                url: "login",
                defaults: new { controller = "Auth", action = "Login" },
                namespaces
             );
        }
    }
}
