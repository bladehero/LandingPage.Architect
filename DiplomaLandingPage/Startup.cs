using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(DiplomaLandingPage.Startup))]

namespace DiplomaLandingPage
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}
