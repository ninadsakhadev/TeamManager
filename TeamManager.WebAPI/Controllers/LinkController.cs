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
    public class LinkController : ApiController
    {
        ILinkService linkService;
        IUnitOfWork unitOfWork;
        public LinkController(ILinkService linkService, IUnitOfWork unitOfWork)
        {
            this.linkService = linkService;
            this.unitOfWork = unitOfWork;
        }
        // GET api/<controller>
        public IEnumerable<Link> Get()
        {
            return linkService.GetAllLinks();
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