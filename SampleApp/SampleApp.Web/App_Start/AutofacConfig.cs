using System.Reflection;
using System.Web.Http;
using Autofac;
using Autofac.Integration.WebApi;
using SampleApp.Core.Interfaces.Services;
using SampleApp.Service;
using SampleApp.DAL;
using SampleApp.Entities.Abstraction;

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