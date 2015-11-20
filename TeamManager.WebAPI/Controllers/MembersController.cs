using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TeamManager.DAL.Common;
using TeamManager.Domain;
using TeamManager.Service;
using TeamManager.WebAPI.Models;

namespace TeamManager.WebAPI.Controllers
{
    public class MembersController : ApiController
    {
        ITeamService teamService;
        IMemberService memberService;
        IUnitOfWork unitOfWork;
        public MembersController(ITeamService teamService, IMemberService memberService, IUnitOfWork unitOfWork)
        {
            this.teamService = teamService;
            this.memberService = memberService;
            this.unitOfWork = unitOfWork;
        }
        // GET api/<controller>
        //public List<TeamDTO> Get()
        //{
        //    // make sure that this also gets into the file. 
        //    List<Team> teams = teamService.GetAllTeams().ToList();
        //    List<TeamDTO> teamsDTO = Mapper.Map<List<TeamDTO>>(teams);
        //    return teamsDTO;
        //}

        // GET api/<controller>/5
        [Route("api/team/{id}/members")]
        public IHttpActionResult Get(int id)
        {
            try
            {
                List<Member> members = teamService.GetById(id).Members.ToList();
                if (members == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(Mapper.Map<List<MemberDTO>>(members));
                }
            }
            catch
            {
                return InternalServerError();
            }
        }

        // GET api/<controller>/5
        [Route("api/members/{memberid}")]
        [Route("api/team/{teamid}/members/{memberid}")]
        public IHttpActionResult Get(int memberid, int? teamid=null)
        {
            try
            {
                Member member = null;
                if (teamid == null)
                {
                    member = memberService.GetById(memberid);
                }
                else
                {
                    if (teamService.GetById((int)teamid,t=>t.Members).Members.Any(t => t.Id == memberid))
                    {
                        member = memberService.GetById(memberid);
                    }
                }

                if (member == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(Mapper.Map<MemberDTO>(member));
                }
            }
            catch
            {
                return InternalServerError();
            }
        }
    }
}
