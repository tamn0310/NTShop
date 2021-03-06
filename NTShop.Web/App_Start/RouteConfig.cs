﻿using System.Web.Mvc;
using System.Web.Routing;

namespace NTShop.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.IgnoreRoute("{*botdetect}",
                    new { botdetect = @"(.*)BotDetectCaptcha\.ashx" });

            routes.MapRoute(
             name: "About",
             url: "lien-he.html",
             defaults: new { controller = "Contact", action = "Index", id = UrlParameter.Optional },
             namespaces: new string[] { "NTShop.Web.Controller" }
         );
            routes.MapRoute(
              name: "Search",
              url: "tim-kiem.html",
              defaults: new { controller = "Product", action = "Search", id = UrlParameter.Optional },
              namespaces: new string[] { "NTShop.Web.Controller" }
          );

            routes.MapRoute(
              name: "Login",
              url: "dang-nhap.html",
              defaults: new { controller = "Account", action = "Login", id = UrlParameter.Optional },
              namespaces: new string[] { "NTShop.Web.Controller" }
          );

            routes.MapRoute(
             name: "Register",
             url: "dang-ky.html",
             defaults: new { controller = "Account", action = "Register", id = UrlParameter.Optional },
             namespaces: new string[] { "NTShop.Web.Controller" }
         );
            routes.MapRoute(
            name: "Cart",
            url: "gio-hang.html",
            defaults: new { controller = "ShoppingCart", action = "Index", id = UrlParameter.Optional },
            namespaces: new string[] { "NTShop.Web.Controller" }
        );
            routes.MapRoute(
            name: "Checkout",
            url: "thanh-toan.html",
            defaults: new { controller = "ShoppingCart", action = "Checkout", id = UrlParameter.Optional },
            namespaces: new string[] { "NTShop.Web.Controller" }
        );
            routes.MapRoute(
               name: "Page",
               url: "trang/{alias}.html",
               defaults: new { controller = "Page", action = "Index", alias = UrlParameter.Optional },
               namespaces: new string[] { "NTShop.Web.Controller" }
           );
            routes.MapRoute(
                name: "Product Category",
                url: "{alias}.pc-{id}.html",
                defaults: new { controller = "Product", action = "Category", id = UrlParameter.Optional },
               namespaces: new string[] { "NTShop.Web.Controller" }
            );
            routes.MapRoute(
                name: "Product",
                url: "{alias}.p-{id}.html",
                defaults: new { controller = "Product", action = "Detail", id = UrlParameter.Optional },
               namespaces: new string[] { "NTShop.Web.Controller" }
            );
            routes.MapRoute(
                name: "Product All",
                url: "san-pham.html",
                defaults: new { controller = "Product", action = "Index", id = UrlParameter.Optional },
               namespaces: new string[] { "NTShop.Web.Controller" }
            );

            routes.MapRoute(
                name: "TagList",
                url: "tag/{tagId}.html",
                defaults: new { controller = "Product", action = "ListByTag", tagid = UrlParameter.Optional },
               namespaces: new string[] { "NTShop.Web.Controller" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}