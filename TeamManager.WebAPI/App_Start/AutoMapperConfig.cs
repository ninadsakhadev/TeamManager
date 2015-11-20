using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using TeamManager.Domain;
using TeamManager.WebAPI.Models;
namespace TeamManager.WebAPI
{
    public static class AutoMapperConfig
    {
        public static void Map()
        {
            Mapper.CreateMap<Team, TeamDTO>();
            Mapper.CreateMap<Member, MemberDTO>();
            Mapper.CreateMap<Leave, LeaveDTO>();
            Mapper.CreateMap<Skill, SkillDTO>();
            Mapper.CreateMap<Certification, CertificationDTO>();
            Mapper.CreateMap<Gender, GenderDTO>();
            //container
            //    .RegisterType<IDataContext, TeamManagerContext>()
            //    .RegisterType<IUnitOfWork, UnitOfWork>()
            //    .RegisterType<IRepository<Team>, Repository<Team>>()
            //    //    .RegisterType<IRepositoryAsync<Product>, Repository<Product>>()
            //    .RegisterType<ITeamService, TeamService>();
            //// register all your components with the container here
            //// it is NOT necessary to register your controllers

            //// e.g. container.RegisterType<ITestService, TestService>();

            //GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}