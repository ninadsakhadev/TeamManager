using TeamManager.DAL.Common;
using TeamManager.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace TeamManager.Service
{
    public class TeamService : ITeamService
    {
        IUnitOfWork unitOfWork;
        IRepository<Team> repository;

        public TeamService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            this.repository = unitOfWork.Repository<Team>();
        }

        public void AddLink(Team team)
        {
            repository.Add(team);
        }

        public IQueryable<Team> GetAllTeams()
        {
            return repository.GetAllWithIncludes("Members");
        }

        public Team GetById(int id, params Expression<Func<Team, object>>[] includeExpressions)
        {
            return repository.GetByIdWithIncludes(t => t.Id == id, includeExpressions);
        }
    }
}
