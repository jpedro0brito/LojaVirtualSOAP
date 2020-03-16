using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace LojaVirtualSOAP
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "webservice",
                routeTemplate: "webservice/{tipo}",
                defaults: new { tipo = RouteParameter.Optional }
            );
        }
    }
}
