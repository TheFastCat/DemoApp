using Microsoft.Owin;
using Owin;
using Microsoft.Owin.Extensions;
using System;
using System.Net;
using Nancy.Owin;

namespace Core
{
    public class CoreStartup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseNancy();
        }
    }
}
