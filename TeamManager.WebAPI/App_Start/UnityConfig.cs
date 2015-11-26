using Microsoft.Practices.Unity;
using TeamManager.DAL;
using TeamManager.DAL.Common;
using TeamManager.Domain;
using TeamManager.Service;
using System.Web.Http;
using Unity.WebApi;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using TeamManager.WebAPI.Helpers;


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
                .RegisterType<ITeamService, TeamService>()
                .RegisterType<IMemberService, MemberService>()
               .RegisterType<IRepository<Member>, Repository<Member>>();
            
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}