using Autofac;
using Autofac.Integration.WebApi;
using SampleApp.Core.Abstraction;
using SampleApp.DAL;
using SampleApp.Service.Provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;

namespace SampleApp.Web
{
    public class AutofacConfig
    {
        public static void RegisterAutofacDependencies()
        {
            var builder = new ContainerBuilder();

            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            builder.RegisterType<ProviderService>().As<IProvider>();
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();
            builder.RegisterType<SampleContext>().AsSelf();

            var container = builder.Build();
            var resolver = new AutofacWebApiDependencyResolver(container);
            GlobalConfiguration.Configuration.DependencyResolver = resolver;
        }
    }
}