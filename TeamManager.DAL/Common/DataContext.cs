using TeamManager.Domain.Common;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamManager.DAL.Common
{
    public class DataContext:DbContext,IDataContext
    {

        //bool isDisposed;
        

        public DataContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }
        public void SyncObjectState<TEntity>(TEntity entity) where TEntity : class, IObjectState
        {
            Entry(entity).State = StateHelper.ConvertState(entity.ObjectState);
        }
        protected override void Dispose(bool disposing)
        {
            //if (!isDisposed)
            //{
            //    if (disposing)
            //    {
            //        // free other managed objects that implement
            //        // IDisposable only
            //    }

            //    // release any unmanaged objects
            //    // set object references to null

            //    isDisposed = true;
            //}

            base.Dispose(disposing);
        }
    }
}
