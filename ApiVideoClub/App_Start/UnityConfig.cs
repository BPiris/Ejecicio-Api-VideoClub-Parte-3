using Microsoft.Practices.Unity;
using System.Web.Http;
using ApiVideoClub.Models;
using ApiVideoClub.Models.ViewModels;
using ApiVideoClub.Repositorios;
using Unity.WebApi;

namespace ApiVideoClub
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();
            
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);

            container.RegisterType<ejercicioVideoclubEntities>();

            container.RegisterType<RepositorioPeliculas>();
            container.RegisterType<RepositorioClientes>();
            container.RegisterType<RepositorioActores>();
            container.RegisterType<RepositorioActores_Peliculas_PK>();
            container.RegisterType<RepositorioActores_Peliculas_Incremental>();
        }
    }
}