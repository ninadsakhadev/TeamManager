using Microsoft.Practices.Unity;
using TeamManager.DAL;
using TeamManager.DAL.Common;
using TeamManager.Domain;
using TeamManager.Service;
using System.Web.Http;
using Unity.WebApi;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;


namespace TeamManager.WebAPI
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            container
                .RegisterType<IDataContext, TeamManagerContext>()
                .RegisterType<IUnitOfWork, UnitOfWork>()
                .RegisterType<IRepository<Team>, Repository<Team>>()
                //    .RegisterType<IRepositoryAsync<Product>, Repository<Product>>()
                .RegisterType<ITeamService, TeamService>();
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();
            
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}