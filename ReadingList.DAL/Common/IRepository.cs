using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TeamManager.Domain;
using TeamManager.Domain.Common;
namespace TeamManager.DAL.Common
{
    public interface IRepository<T> where T : Entity
    {

        IEnumerable<T> GetAll();

        IEnumerable<T> GetAllWithIncludes(string predicate);
        IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void Delete(T entity);
        void Edit(T entity);
    }
}
