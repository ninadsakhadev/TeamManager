using TeamManager.DAL.Common;
using TeamManager.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamManager.Service
{
    public class TeamService : ITeamService
    {
        IRepository<Team> repository;

        public TeamService(IRepository<Team> repository)
        {
            this.repository = repository;
        }

        public void AddLink(Team team)
        {
            repository.Add(team);
        }

        public IEnumerable<Team> GetAllTeams()
        {
            return repository.GetAllWithIncludes("Members");
        }
    }
}
