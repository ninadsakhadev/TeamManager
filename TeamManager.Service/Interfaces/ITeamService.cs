using TeamManager.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TeamManager.Service
{
    public interface ITeamService
    {
        void AddLink(Team team);

        IEnumerable<Team> GetAllTeams();

        Team GetById(int id, params Expression<Func<Team, object>>[] includeExpressions);

        //IEnumerable<Link> Find(Expression<Func<Link, bool>> predicate);
    }
}
