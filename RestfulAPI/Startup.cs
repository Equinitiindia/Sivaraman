using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;
using RestfulAPI.Repositories;

[assembly: OwinStartup(typeof(RestfulAPI.Startup))]

namespace RestfulAPI
{
    public partial class Startup
    {
        public static TransactionRepository Repository { get; set; }
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            Repository = new TransactionRepository();
        }
    }
}
