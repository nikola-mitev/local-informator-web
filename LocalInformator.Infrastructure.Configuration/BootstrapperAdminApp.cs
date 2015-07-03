using LocalInformator.Infrastructure.Configuration.Dependencies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LocalInformator.Infrastructure.Configuration
{
    public class BootstrapperAdminApp
    {
        public static Assembly WebAppAssembly = Assembly.Load("LocalInformator.AdminApp");


        public static void Bootstrap()
        {
            AutofacWebAppConfiguration.RegisterComponents();
        }
    }
}
