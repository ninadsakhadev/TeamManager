using TeamManager.DAL.Common;
using TeamManager.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamManager.Service
{
    public class LinkService : ILinkService
    {
        IRepository<Link> repository;
        
        public LinkService(IRepository<Link> repository)
        {
            this.repository = repository;
        }

        public void AddLink(Link link)
        {
            repository.Add(link);
        }

        public IEnumerable<Link> GetAllLinks()
        {
            return repository.GetAll();
        }
    }
}
