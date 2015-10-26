using TeamManager.Domain.Common;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace TeamManager.DAL.Common
{
    public interface IDataContext : IDisposable
    {
        int SaveChanges();

        void SyncObjectState<TEntity>(TEntity entity) where TEntity : class, IObjectState;
        //void SyncObjectsStatePostCommit();
    }
}
