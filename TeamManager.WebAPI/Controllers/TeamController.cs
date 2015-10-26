using TeamManager.DAL.Common;
using TeamManager.Domain;
using TeamManager.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TeamManager.WebAPI.Controllers
{
    public class TeamController : ApiController
    {
        ITeamService teamService;
        IUnitOfWork unitOfWork;
        public TeamController(ITeamService teamService, IUnitOfWork unitOfWork)
        {
            this.teamService = teamService;
            this.unitOfWork = unitOfWork;
        }
        // GET api/<controller>
        public List<Team> Get()
        {
            // write another get that works
            List<Team> teams = teamService.GetAllTeams().ToList();
            return teams;
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}