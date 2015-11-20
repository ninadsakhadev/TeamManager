using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TeamManager.Domain;
using TeamManager.Domain.Common;

namespace TeamManager.DAL.Common
{
    public class Repository<T> : IRepository<T>
       where T : Entity, IObjectState
    {
        protected IDataContext context;
        protected readonly IDbSet<T> dbSet;

        public Repository(IDataContext context)
        {
            this.context = context;
            var dbContext = context as DbContext;
            if (dbContext != null)
            {
                this.dbSet = dbContext.Set<T>();
            }
        }

        public virtual IEnumerable<T> GetAll()
        {
            return dbSet.AsEnumerable<T>();
        }

        public virtual IEnumerable<T> GetAllWithIncludes(string predicate)
        {
            return dbSet.Include<T>(predicate).AsEnumerable<T>();
        }

        public virtual T GetByIdWithIncludes(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeExpressions)
        {
            if (includeExpressions.Any())
            {
                var set = includeExpressions.Aggregate<Expression<Func<T, object>>, IQueryable<T>>
                         (this.dbSet, (current, expression) => current.Include(expression));

                return set.SingleOrDefault(predicate);
            }

            return dbSet.Where(predicate).FirstOrDefault();
        }

        public virtual T GetByIdWithIncludes(Expression<Func<T, bool>> predicate, string includeExpressions = "")
        {
            var query = dbSet.AsQueryable<T>();
            if (includeExpressions.Length > 0)
            {
                string[] includeExpressionsList = includeExpressions.Split(',');
                foreach (string includeExpression in includeExpressionsList)
                {
                    query = query.Include(includeExpression);
                }
            }

            return query.Where(predicate).FirstOrDefault();
        }

        public IEnumerable<T> FindBy(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {

            IEnumerable<T> query = dbSet.Where(predicate).AsEnumerable();
            return query;
        }

        public virtual void Add(T entity)
        {
            entity.ObjectState = ObjectState.Added; ;
            dbSet.Attach(entity);
            context.SyncObjectState(entity);
        }

        public virtual void Delete(T entity)
        {
            entity.ObjectState = ObjectState.Deleted;
            dbSet.Attach(entity);
            context.SyncObjectState(entity);
        }

        public virtual void Edit(T entity)
        {
            entity.ObjectState = ObjectState.Modified;
            dbSet.Attach(entity);
            context.SyncObjectState(entity);
        }
    }
}
