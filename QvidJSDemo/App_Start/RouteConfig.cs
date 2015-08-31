using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace QvidJSDemo
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Invoices",
                url: "Invoices",
                defaults: new { controller = "Invoices", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "CustomerOrders",
                url: "Customers/Orders/{id}",
                defaults: new { controller = "Customers", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "CustomerDetails",
                url: "Customers/Details/{id}",
                defaults: new { controller = "Customers", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Customers",
                url: "Customers",
                defaults: new { controller = "Customers", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Customers", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}