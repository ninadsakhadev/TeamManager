using TeamManager.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TeamManager.Service
{
    public interface ILinkService
    {
        void AddLink(Link link);

        IEnumerable<Link> GetAllLinks();

        //IEnumerable<Link> Find(Expression<Func<Link, bool>> predicate);
    }
}
