﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LocalInformator.WebApp.Startup))]
namespace LocalInformator.WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
