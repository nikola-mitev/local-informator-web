using Autofac;
using Autofac.Integration.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
namespace LocalInformator.Infrastructure.Configuration.Dependencies
{
    public class AutofacAdminAppConfiguration
    {
        public static IContainer RegisterComponents()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(BootstrapperAdminApp.WebAppAssembly);
            builder.RegisterFilterProvider();

            builder.RegisterAssemblyModules(typeof(AutofacWebAppConfiguration).Assembly);

            // Create the container
            var container = builder.Build();

            // Set the dependency resolver for MVC
            DependencyResolver.SetResolver(new Autofac.Integration.Mvc.AutofacDependencyResolver(container));

            return container;
        }
    }
}
