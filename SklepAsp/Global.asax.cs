using Autofac;
using Autofac.Integration.Mvc;
using SklepAsp.Controllers;
using SklepAsp.Models;
using SklepAsp.Repositories;
using SklepAsp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace SklepAsp
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            ConfigureContainer();
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
        private void ConfigureContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterType<HomeController>().InstancePerRequest();
            builder.RegisterType<ProductsController>().InstancePerRequest();
            builder.RegisterType<ProductRepository>().AsImplementedInterfaces().InstancePerRequest();
            builder.RegisterType<ProductService>().AsImplementedInterfaces().InstancePerRequest();
            builder.RegisterType<SklepAspContext>().InstancePerRequest();
            builder.RegisterAssemblyModules(typeof(MvcApplication).Assembly);
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}
