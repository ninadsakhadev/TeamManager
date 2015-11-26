using TeamManager.DAL.Common;
using TeamManager.Domain;
using TeamManager.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TeamManager.WebAPI.Models;
using AutoMapper;
using TeamManager.WebAPI.Helpers;
using System.Web.Http.Routing;
using System.Web;
namespace TeamManager.WebAPI.Controllers
{
    public class TeamController : BaseController
    {
        ITeamService teamService;

        public TeamController(ITeamService teamService)
        {
            this.teamService = teamService;
        }
        // GET api/<controller>
        [Route("api/team", Name = "Teams")]
        public IHttpActionResult Get(string sort = "id", int page = 1, int pageSize = 1)
        {
            try
            {
                var teams = teamService.GetAllTeams().ApplySort(sort);

                if (teams == null || teams.Count() == 0)
                {
                    return NotFound();
                }
                else
                {
                    base.AddPagination(teams, page, pageSize, "Teams", sort);

                    teams = teams.Skip(pageSize * (page - 1)).Take(pageSize);

                    return Ok(Mapper.Map<List<TeamDTO>>(teams));
                }

            }
            catch
            {
                return InternalServerError();
            }
            // make sure that this also gets into the file. 

        }

        // GET api/<controller>/5
        public IHttpActionResult Get(int id)
        {
            try
            {
                Team team = teamService.GetById(id, t => t.Members);
                if (team == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(Mapper.Map<TeamDTO>(team));
                }

            }
            catch
            {
                return InternalServerError();
            }
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