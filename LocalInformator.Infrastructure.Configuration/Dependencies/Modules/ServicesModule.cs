using Autofac;
using LocalInformator.Services.Commands;
using LocalInformator.Services.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalInformator.Infrastructure.Configuration.Dependencies.Modules
{
    public class ServicesModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(typeof(IQueryHandler<,>).Assembly).AsClosedTypesOf(typeof(IQueryHandler<,>)).AsImplementedInterfaces().AsSelf().SingleInstance();
            builder.RegisterAssemblyTypes(typeof(ICommandHandler<>).Assembly).AsClosedTypesOf(typeof(ICommandHandler<>)).AsImplementedInterfaces().AsSelf().SingleInstance();
            builder.RegisterAssemblyTypes(typeof(IDeleteEntityCommandHandler<>).Assembly).AsClosedTypesOf(typeof(IDeleteEntityCommandHandler<>)).AsImplementedInterfaces().AsSelf().SingleInstance();
        }
    }
}
