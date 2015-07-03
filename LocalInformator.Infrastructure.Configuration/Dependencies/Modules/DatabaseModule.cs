using Autofac;
using LocalInformator.Infrastructure.Dapper.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalInformator.Infrastructure.Configuration.Dependencies.Modules
{
    public class DatabaseModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<RepositoryDapper>().SingleInstance();
        }
    }
}
