using Owin;
using Microsoft.Owin.Extensions;
using System;
using System.Net;
using Core;
using Api;

namespace Website
{
    public class WebAppStartup
    {
        public void Configuration(IAppBuilder app)
        {
            new ApiStartup().Configuration(app);
            new CoreStartup().Configuration(app);
        }
    }
}
