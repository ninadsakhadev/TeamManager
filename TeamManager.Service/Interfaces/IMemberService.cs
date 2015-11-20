using TeamManager.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TeamManager.Service
{
    public interface IMemberService
    {
        void AddMember(Member team);

        IEnumerable<Member> GetAllMembers();

        Member GetById(int id);

        //IEnumerable<Link> Find(Expression<Func<Link, bool>> predicate);
    }
}
