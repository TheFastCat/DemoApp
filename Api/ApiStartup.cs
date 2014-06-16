using Microsoft.Owin;
using Owin;
using Microsoft.Owin.Extensions;
using System;
using System.Net;
using System.Web.Http;

namespace Api
{
    public class ApiStartup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();
            config.MapHttpAttributeRoutes();
            config.EnableSystemDiagnosticsTracing();
            config.Formatters.XmlFormatter.SupportedMediaTypes.Clear();
            app.UseWebApi(config);
        }
    }
}
