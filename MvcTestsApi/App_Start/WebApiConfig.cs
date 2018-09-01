using System.Web.Http;

namespace MvcTestsApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            /*In the MvcTests project create a route to /invitationdigital/tests/{index} that takes an optional integer parameter index.*/
            config.Routes.MapHttpRoute(
                name: "Invitationdigital",
                routeTemplate: "invitationdigital/{test}/{index}",
                defaults: new { index = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "test",
                routeTemplate: "api/{controller}/{index}",
                defaults: new { index = RouteParameter.Optional }
            );

            config.EnableSystemDiagnosticsTracing();
        }
    }
}