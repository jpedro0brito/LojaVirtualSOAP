using LojaVirtualSOAP.Context;
using LojaVirtualSOAP.Repository;
using LojaVirtualSOAP.Repository.Intefaces;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace LojaVirtualSOAP
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            container.RegisterType<IClienteRepository, ClienteRepository>();
            container.RegisterType<IEnderecoRepository, EnderecoRepository>();
            container.RegisterType<LojaVirtualDbContext, LojaVirtualDbContext>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}