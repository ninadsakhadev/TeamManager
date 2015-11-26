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

        IQueryable<T> GetAll();

        IQueryable<T> GetAllWithIncludes(string predicate);
        IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);
        IQueryable<T> FindByWithIncludes(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeExpressions);
        T GetByIdWithIncludes(Expression<Func<T, bool>> filter, params Expression<Func<T, object>>[] includeExpressions);
        T GetByIdWithIncludes(Expression<Func<T, bool>> predicate, string includeExpressions);
        void Add(T entity);
        void Delete(T entity);
        void Edit(T entity);
    }
}
