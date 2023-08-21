using Autofac;
using Nlayer.Caching;
using Nlayer.Repository;
using Nlayer.Repository.Repositories;
using Nlayer.Repository.UnitOfWorks;
using Nlayer.Service.Mapping;
using Nlayer.Service.Services;
using NLayer.Core.Repositories;
using NLayer.Core.Services;
using NLayer.Core.UnitOfWorks;
using System.Reflection;
using Module = Autofac.Module;

namespace Nlayer.API.Modules
{
    public class RepoServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterGeneric(typeof(GenericRepository<>)).As(typeof(IGenericRepository<>)).InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(Service<>)).As(typeof(IService<>)).InstancePerLifetimeScope();
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();
            
            
            var apiAssembly = Assembly.GetExecutingAssembly();
            var repoAssembly = Assembly.GetAssembly(typeof(AppDbContext));
            var serviceAssembly = Assembly.GetAssembly(typeof(MapProfile));



            builder.RegisterAssemblyTypes(apiAssembly, repoAssembly, serviceAssembly).Where(x=>x.Name.EndsWith("Repository")).AsImplementedInterfaces().InstancePerLifetimeScope().InstancePerLifetimeScope();
            
            builder.RegisterAssemblyTypes(apiAssembly, repoAssembly, serviceAssembly).Where(x=>x.Name.EndsWith("Service")).AsImplementedInterfaces().InstancePerLifetimeScope().InstancePerLifetimeScope();

            builder.RegisterType<ProductServiceWithCaching>().As<IProductService>();


        }
    }
}
