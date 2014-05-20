using Nancy;
using System.IO;
using System.Web;

namespace NancyWeb.Modules.Home
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = parameteres =>
            {
                var path = Path.Combine(HttpContext.Current.Server.MapPath("~/"), "config.xml");
                return File.Exists(path) ? (dynamic)this.View["Index"] : Response.AsRedirect("/install");
            };
        }
    }
}