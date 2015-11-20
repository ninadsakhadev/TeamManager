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
        public IHttpActionResult Get()
        {
            try
            {
                List<Team> teams = teamService.GetAllTeams().ToList();
                if (teams == null || teams.Count == 0)
                {
                    return NotFound();
                }
                else
                { 
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
                Team team = teamService.GetById(id);
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